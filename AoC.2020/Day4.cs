namespace AoC2020;

public class Day4 : Day
{
    public override string Title => "Day 4";

    public override void PartOne()
    {
        base.PartOne();
        var input = Inputs.Day4.Split('\n').Select(s => s.Replace("\r", "")).ToList();

        var passports = new List<Passport2>();
        var currentPassport = new List<string>();

        foreach (var line in input)
        {
            if (string.IsNullOrWhiteSpace(line) && currentPassport.Count > 0)
            {
                passports.Add(new Passport2(currentPassport));
                currentPassport.Clear();
                continue;
            }

            currentPassport.AddRange(line.Split(' '));
        }

        passports.Add(new Passport2(currentPassport));

        var result = passports.Count(p => p.IsValid());
        Console.WriteLine(result);
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var input = Inputs.Day4.Split('\n').Select(s => s.Replace("\r", "")).ToList();

        var passports = new List<Passport>();
        var currentPassport = new List<string>();

        foreach (var line in input)
        {
            if (string.IsNullOrWhiteSpace(line) && currentPassport.Count > 0)
            {
                passports.Add(new Passport(currentPassport));
                currentPassport.Clear();
                continue;
            }

            currentPassport.AddRange(line.Split(' '));
        }

        passports.Add(new Passport(currentPassport));

        var result = passports.Count(p => p.IsValid());
        Console.WriteLine(result);
    }

    public class Passport
    {
        public int? Byr { get; set; }
        public int? Iyr { get; set; }
        public int? Eyr { get; set; }
        public int? Hgt { get; set; }
        public string Hcl { get; set; }
        public string Ecl { get; set; }
        public long? Pid { get; set; }
        public string Cid { get; set; }

        public Passport(IEnumerable<string> passportBatchEntry)
        {
            foreach (var property in passportBatchEntry.Select(s => s.Split(':')))
            {
                var code = property[0];
                var value = property[1];

                switch (code)
                {
                    case "byr":
                        SetByr(value);
                        break;
                    case "iyr":
                        SetIyr(value);
                        break;
                    case "eyr":
                        SetEyr(value);
                        break;
                    case "hgt":
                        SetHgt(value);
                        break;
                    case "hcl":
                        SetHcl(value);
                        break;
                    case "ecl":
                        SetEcl(value);
                        break;
                    case "pid":
                        SetPid(value);
                        break;
                    case "cid":
                        Cid = value;
                        break;
                    default:
                        throw new ArgumentException(code);
                }
            }
        }

        private void SetByr(string value)
        {
            if (value.Length == 4 && int.TryParse(value, out var year) && year >= 1920 && year <= 2002)
            {
                Byr = year;
            }
        }

        private void SetIyr(string value)
        {
            if (value.Length == 4 && int.TryParse(value, out var year) && year >= 2010 && year <= 2020)
            {
                Iyr = year;
            }
        }

        private void SetEyr(string value)
        {
            if (value.Length == 4 && int.TryParse(value, out var year) && year >= 2020 && year <= 2030)
            {
                Eyr = year;
            }
        }

        private void SetHgt(string value)
        {
            if (value.EndsWith("cm") && int.TryParse(value.RemoveNonNumeric(), out var height) && height >= 150 && height <= 193)
            {
                Hgt = height;
            }
            else if (value.EndsWith("in") && int.TryParse(value.RemoveNonNumeric(), out var height2) && height2 >= 59 && height2 <= 76)
            {
                Hgt = height2;
            }
        }

        private void SetHcl(string value)
        {
            if (!value.StartsWith("#"))
            {
                return;
            }

            if (value.Length == 7 && Regex.IsMatch(value.Substring(1, 6), "[a-f0-9]"))
            {
                Hcl = value;
            }
        }

        private void SetEcl(string value)
        {
            var valid = new string[] { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };
            if (value.Length == 3 && valid.Contains(value))
            {
                Ecl = value;
            }
        }

        private void SetPid(string value)
        {
            if (value.Length == 9 && value.All(char.IsDigit))
            {
                Pid = long.Parse(value);
            }
        }

        public bool IsValid()
        {
            return Byr.HasValue && Iyr.HasValue && Eyr.HasValue && Hgt.HasValue &&
                   Hcl != null && Ecl != null && Pid.HasValue;
        }
    }

    public class Passport2
    {
        public string Byr { get; set; }
        public string Iyr { get; set; }
        public string Eyr { get; set; }
        public string Hgt { get; set; }
        public string Hcl { get; set; }
        public string Ecl { get; set; }
        public string Pid { get; set; }
        public string Cid { get; set; }

        public Passport2(IEnumerable<string> passportBatchEntry)
        {
            foreach (var property in passportBatchEntry.Select(s => s.Split(':')))
            {
                var code = property[0];
                var value = property[1];

                switch (code)
                {
                    case "byr":
                        Byr = value;
                        break;
                    case "iyr":
                        Iyr = value;
                        break;
                    case "eyr":
                        Eyr = value;
                        break;
                    case "hgt":
                        Hgt = value;
                        break;
                    case "hcl":
                        Hcl = value;
                        break;
                    case "ecl":
                        Ecl = value;
                        break;
                    case "pid":
                        Pid = value;
                        break;
                    case "cid":
                        Cid = value;
                        break;
                    default:
                        throw new ArgumentException(code);
                }
            }
        }

        public bool IsValid()
        {
            return Byr != null && Iyr != null && Eyr != null && Hgt != null &&
                   Hcl != null && Ecl != null && Pid != null;
        }
    }
}