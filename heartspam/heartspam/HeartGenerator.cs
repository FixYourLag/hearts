namespace heartSpam;

public class HeartGenerator
{ 
    public string[] MakeSpam(int len)
    {
        string[] possibleHearts =
        {
            "โค", "๐งก", "๐", "๐", "๐", "๐", "๐ค", "๐ค", "๐ค", "๐", "โฃ", "๐", "๐", "๐", "๐", "๐", "๐", "๐",
            "๐", "โค๏ธโ๐ฅ", "โค๏ธโ๐ฉน"
        };
        var rnd = new Random();

        var spam = new string[len];

        for (var i = 0; i < spam.Length; i++)
        {
            var index = rnd.Next(possibleHearts.Length);
            spam[i] = possibleHearts[index];
        }

        return spam;
    }
}