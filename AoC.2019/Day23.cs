namespace AoC2019;
/*
--- Day 23: Category Six ---
The droids have finished repairing as much of the ship as they can. 
Their report indicates that this was a Category 6 disaster - not because it was that bad, but because it destroyed the stockpile of Category 6 network cables as well as most of the ship's network infrastructure.

You'll need to rebuild the network from scratch.

The computers on the network are standard Intcode computers that communicate by sending packets to each other. 
There are 50 of them in total, each running a copy of the same Network Interface Controller (NIC) software (your puzzle input). 
The computers have network addresses 0 through 49; when each computer boots up, it will request its network address via a single input instruction. 
Be sure to give each computer a unique network address.

Once a computer has received its network address, it will begin doing work and communicating over the network by sending and receiving packets. All packets contain two values named X and Y. Packets sent to a computer are queued by the recipient and read in the order they are received.

To send a packet to another computer, the NIC will use three output instructions that provide the destination address of the packet followed by its X and Y values. For example, three output instructions that provide the values 10, 20, 30 would send a packet with X=20 and Y=30 to the computer with address 10.

To receive a packet from another computer, the NIC will use an input instruction. If the incoming packet queue is empty, provide -1. Otherwise, provide the X value of the next packet; the computer will then use a second input instruction to receive the Y value for the same packet. Once both values of the packet are read in this way, the packet is removed from the queue.

Note that these input and output instructions never block. Specifically, output instructions do not wait for the sent packet to be received - the computer might send multiple packets before receiving any. Similarly, input instructions do not wait for a packet to arrive - if no packet is waiting, input instructions should receive -1.

Boot up all 50 computers and attach them to your network. What is the Y value of the first packet sent to address 255?

Your puzzle answer was 23886.

--- Part Two ---
Packets sent to address 255 are handled by a device called a NAT (Not Always Transmitting). The NAT is responsible for managing power consumption of the network by blocking certain packets and watching for idle periods in the computers.

If a packet would be sent to address 255, the NAT receives it instead. The NAT remembers only the last packet it receives; that is, the data in each packet it receives overwrites the NAT's packet memory with the new packet's X and Y values.

The NAT also monitors all computers on the network. If all computers have empty incoming packet queues and are continuously trying to receive packets without sending packets, the network is considered idle.

Once the network is idle, the NAT sends only the last packet it received to address 0; this will cause the computers on the network to resume activity. In this way, the NAT can throttle power consumption of the network when the ship needs power in other areas.

Monitor packets released to the computer at address 0 by the NAT. What is the first Y value delivered by the NAT to the computer at address 0 twice in a row?

Your puzzle answer was 18333.
*/

public class Day23 : Day
{
    public override string Title => "--- Day 23: Category Six ---";

    public override void PartOne()
    {
        base.PartOne();
        var ips = Enumerable.Range(0, 50);
        var network = new ConcurrentDictionary<long, Computer>();
        var cancel = false;
        var computers = new List<Computer>();

        foreach (var ip in ips)
        {
            var computer = new Computer(ip, network, true, ref cancel);
            network.AddOrUpdate(ip, computer, (i, c) => c);
            computers.Add(computer);
        }

        while (cancel != true)
        {
            foreach (var c in computers)
            {
                c.Run();
            }
        }

        Console.WriteLine("done");
    }

    public override void PartTwo()
    {
        base.PartTwo();

        var ips = Enumerable.Range(0, 50);
        var network = new ConcurrentDictionary<long, Computer>();
        var cancel = false;
        var computers = new List<Computer>();

        foreach (var ip in ips)
        {
            var computer = new Computer(ip, network, false, ref cancel);
            network.AddOrUpdate(ip, computer, (i, c) => c);
            computers.Add(computer);
        }

        var nat = new Nat(255, network, true, ref cancel);
        network.AddOrUpdate(255, nat, (i, n) => n);
        computers.Add(nat);

        while (cancel != true)
        {
            foreach (var c in computers)
            {
                c.Run();
            }
        }

        Console.WriteLine("done");
    }
}

public class Nat : Computer
{
    private List<Packet> ReceivedPackets = new List<Packet>();
    private List<Packet> DeliveredPackets = new List<Packet>();

    public Nat(long ip, ConcurrentDictionary<long, Computer> network, bool canCancel, ref bool cancel) : base(ip,
        network, canCancel, ref cancel)
    {
        Idle = true;
    }

    public override void Run()
    {
        while (!_packetQueue.IsEmpty)
        {
            if (_packetQueue.TryDequeue(out var incoming))
            {
                Console.WriteLine($"NAT -> received packet");
                ReceivedPackets.Add(incoming);
            }
        }

        if (_network.Values.All(a => a.Idle) && ReceivedPackets.Any())
        {
            Console.WriteLine("NAT -> all idle sending last packet");
            var packetToDeliver = ReceivedPackets.Last();

            _network.TryGetValue(0, out var computerZero);
            computerZero.Put(packetToDeliver);

            if (DeliveredPackets.Count > 2 && DeliveredPackets[DeliveredPackets.Count - 1].Y == packetToDeliver.Y &&
                DeliveredPackets[DeliveredPackets.Count - 2].Y == packetToDeliver.Y)
            {
                Console.WriteLine(" NAT -> Twice found " + packetToDeliver.Y);
                _cancel = true;
            }

            DeliveredPackets.Add(packetToDeliver);
        }
    }
}

public class Computer
{
    private IntCodeProgram _intCodeProgram;
    protected ConcurrentQueue<Packet> _packetQueue = new ConcurrentQueue<Packet>();
    protected readonly ConcurrentDictionary<long, Computer> _network;
    private readonly bool _canCancel;
    protected bool _cancel;
    public long Ip;
    private List<long> outputs = new List<long>();
    public bool Idle;

    public Computer(long ip, ConcurrentDictionary<long, Computer> network, bool canCancel, ref bool cancel)
    {
        Ip = ip;
        _network = network;
        _canCancel = canCancel;
        _cancel = cancel;

        var input = Inputs.Day23.SplitAsLongsBy(',').ToArray().ExpandTo(100000);
        _intCodeProgram = new IntCodeProgram(input);
        _intCodeProgram.AddInput(ip);
    }

    public void Put(Packet newPacket)
    {
        _packetQueue.Enqueue(newPacket);
    }

    public virtual void Run()
    {
        while (!_cancel && !_intCodeProgram.IsTerminated)
        {
            if (!_packetQueue.IsEmpty)
            {
                _packetQueue.TryDequeue(out var incomingPacket);
                Console.WriteLine($"{Ip} packet received");

                _intCodeProgram.AddInput(incomingPacket.X);
                _intCodeProgram.AddInput(incomingPacket.Y);
            }
            else
            {
                //await Task.Delay(1000);
            }

            _intCodeProgram.LoopUntilHalt(-1);
            if (_intCodeProgram.IsHalted2)
            {
                if (_packetQueue.IsEmpty)
                {
                    Idle = true;
                }

                break;
            }

            Idle = false;

            outputs.Add(_intCodeProgram.Output);

            if (outputs.Count == 3)
            {
                var packet = new Packet
                {
                    ReceiverIp = outputs[0],
                    X = outputs[1],
                    Y = outputs[2]
                };

                if (packet.ReceiverIp == 255)
                {
                    Console.WriteLine($"{Ip} -> Ip {packet.ReceiverIp}, X {packet.X}, Y {packet.Y}");
                    if (_canCancel)
                    {
                        _cancel = true;
                    }
                }

                if (_network.TryGetValue(packet.ReceiverIp, out var comp))
                {
                    Console.WriteLine($"{Ip} -> Packet queued for ip {packet.ReceiverIp}");
                    comp.Put(packet);
                }
                else
                {
                    Console.WriteLine($"{Ip} -> Packet created for ip outside network ip {packet.ReceiverIp}");
                }

                outputs.Clear();
            }
        }
    }
}

public class Packet
{
    public long ReceiverIp;
    public long X;
    public long Y;
}