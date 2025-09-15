using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TextValidation
/// </summary>
public class TextValidation
{
	public TextValidation()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public string TextValid(string value)
    {

        string[] TextSplit = value.Split('>');
        string final = "";
        for (int i = 0; i < TextSplit.Length; i++)
        {
            if (TextSplit[i].ToLower().Contains("class="))
            {
                final += TextSplit[i].Trim().Replace("class=", "class=\"") + "\"" + ">";

            }
            else if (TextSplit[i].ToLower().Contains("</p"))
                final += TextSplit[i].Trim() + ">";
            else
                if (!string.IsNullOrEmpty(TextSplit[i]) & (TextSplit[i].Contains(">") || TextSplit[i].Contains("<")))
                {
                    if (TextSplit[i].ToLower().Contains("color="))
                    {
                        final += TextSplit[i].Trim().Replace("color=", "color=\"") + "\"" + ">";
                    }
                    else
                        if (TextSplit[i].ToLower().Contains("target="))
                            final += TextSplit[i].Trim().Replace("target=", "target=\"") + "\"" + ">";
                        else
                            final += TextSplit[i].Trim() + ">";
                }
                else if (!string.IsNullOrEmpty(TextSplit[i]))
                    final += TextSplit[i].Trim();

        }

        return final;
    }
}
