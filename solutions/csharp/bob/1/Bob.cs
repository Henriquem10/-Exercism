using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        if (string.IsNullOrWhiteSpace(statement))
        {
            return "Fine. Be that way!";
        }
        bool isCaps = true;
        for (int i = 0; i < statement.Length; i++){
            if (Char.IsLetter(statement[i]) && !Char.IsUpper(statement[i]))
                isCaps = false;            
        }
        if (!statement.Any(Char.IsLetter)){
            isCaps = false;
        }
        
        if (isCaps == true && statement.EndsWith("?")){
            return "Calm down, I know what I'm doing!";
        }
        
        if (isCaps == true){
            return "Whoa, chill out!";
        }
        
        if (statement.Trim().EndsWith("?")){
            return "Sure.";
        }

        else{
            return "Whatever.";
        }
    }
}