class passport
{







    private string passnum;

    public string Passnum
    {
        get { return passnum; }
        set { passnum = value; }
    }
    private string fullname;

    public string Fullname
    {
        get { return fullname; }
        set { fullname = value; }
    }
    private DateTime issuedata;

    public DateTime Issuedata
    {
        get { return issuedata; }
        set { issuedata = value; }
    }
    private DateTime expirat;

    public DateTime Expirat
    {
        get { return expirat; }
        set { expirat = value; }
    }


    public passport(string fullname, string passnum, DateTime issuedata, DateTime expirat)
    {
        this.fullname = fullname;
        this.passnum = passnum;
        this.issuedata = issuedata;
        this.expirat = expirat;

    }


    private bool IsValidPassportNumber(string number)
    {
        foreach (char c in number)
        {
            if (!char.IsLetterOrDigit(c))
            {
                return false;
            }
        }
        return true;
    }


    public override string ToString()
    {
        return $"Passport : {passnum}\n" +
               $"PIB: {fullname}\n" +
               $"Date: {issuedata:dd.MM.yyyy}\n" +
               $"Date end: {expirat:dd.MM.yyyy}";
    }

    class Program
    {
        static void Main()
        {
            try
            {

                var passport = new passport(
                    passnum: "AB1234567",
                    fullname: "Liaschuk Anastasia Sergiivna",
                    issuedata: new DateTime(2020, 5, 15),
                    expirat: new DateTime(2030, 5, 14)
                );

                Console.WriteLine(passport);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");





            }
        }
    }
}