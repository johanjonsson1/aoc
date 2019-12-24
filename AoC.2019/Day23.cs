using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*

    */

    public class Day23 : Day
    {
        public override string Title => "";

        public override void PartOne()
        {
            base.PartOne();
            return;
            var ips = Enumerable.Range(0, 50);
            var tasks = new List<Task>();
            var network = new ConcurrentDictionary<long, Computer>();
            var cancel = false;
            var computers = new List<Computer>();

            foreach (var ip in ips)
            {
                //var t = Task.Run(async () =>
                //{
                    var computer = new Computer(ip, network, true, ref cancel);
                    network.AddOrUpdate(ip, computer, (i, c) => c);
                //    await Task.Delay(500);
                //    await computer.Run();
                //});
                computers.Add(computer);
                //tasks.Add(t);
            }

            while (cancel != true)
            {
                foreach (var c in computers)
                {
                    c.Run();
                }
            }

            //var tt = Task.WhenAll(tasks);
            //tt.Wait();

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

        public Nat(long ip, ConcurrentDictionary<long, Computer> network, bool canCancel, ref bool cancel) : base(ip, network, canCancel, ref cancel)
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
                
                if (DeliveredPackets.Count > 2 && DeliveredPackets[DeliveredPackets.Count-1].Y == packetToDeliver.Y && DeliveredPackets[DeliveredPackets.Count-2].Y == packetToDeliver.Y)
                {
                    Console.WriteLine(" NAT -> Twice found "+ packetToDeliver.Y);
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
}