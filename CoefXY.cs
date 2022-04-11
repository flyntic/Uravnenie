using System.Data.SqlTypes;

namespace ConsoleApp3;

public class CoefXY
{
    public float A { get; set; }
    public float B { get; set; }
    public float C { get; set; }

    public static CoefXY Parse(string s)
    {
        string[] str = s.Split(',', ' ');

        return new CoefXY {A = Int32.Parse(str[0]), B = Int32.Parse(str[1]), C = Int32.Parse(str[2]),};
    }

    public override string ToString()
    {
        return $"{A} * x + {B} * y = {C}";
    }

    public static bool operator true(CoefXY c)
    {
        return (c.A == 0 & c.B == 0 & c.C == 0);
    }

    public static bool operator false(CoefXY c)
    {
        return (c.A == 0 | c.B == 0 | c.C == 0);
    }

    public static string Decide(CoefXY c1, CoefXY c2)
    {
        if (c1) return "Один из коеффициентов ==0 ";
        if (c2) return "Один из коеффициентов ==0 ";

        float check_zero = c1.A * c2.B - c2.A * c1.B;


        if (check_zero == 0) return "Бесконечное число решений  ";

        float XX = (c1.C * c2.B - c2.C * c1.B) / check_zero;

      //  check_zero = c1.A * c2.B - c1.B * c2.A;
        if (check_zero == 0) return "Бесконечное число решений  ";

        float YY = (c1.A * c2.C - c2.A * c1.C) / check_zero;

        return ($" X= {XX} ; Y={YY}");
    }
}