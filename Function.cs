namespace WinFormsAppX;

public class Function
{
    public Nullable<double> a;
    public Nullable<double> b;
    public Nullable <double> c;

    public Function() 
    {
        a = null;
        b = null;
        c = null;
    }
    
    public Function(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double setA(String a)
    {
        try
        {
            this.a = Convert.ToDouble(a);
            return (double) (this.a);
        } catch 
        {
            return this.a != null ? (double)(this.a) : 0;
        }
    }
    public double setB(String b)
    {
        try
        {
            this.b = Convert.ToDouble(b);
            return (double)(this.b);
        }
        catch
        {
            return this.b != null ? (double)(this.b) : 0;
        }
    }
    public double setC(String c)
    {
        try
        {
            this.c = Convert.ToDouble(c);
            return (double)(this.c);
        }
        catch
        {
            return this.c != null ? (double)(this.c) : 0;
        }
    }

    public bool isComplete()
    {
        return (
            this.a != null
            && this.b != null
            && this.c != null
            );
    }

    private double f(double x)
    {
        if (!isComplete())
            return 0;
        return (double)(a) * Math.Pow((double)(x), 2) + (double)(b) * (double)(x) + (double)(c);
    }
    
    public double getValueOf(double x)
    {
        return f(x);
    }

    public String getY(String y)
    {
        try
        {
            return f(Convert.ToDouble(y)).ToString();
        } catch (Exception e)
        {
            return e.Message;
        }
    }

    String getLowerX()
    {
        try
        {
            return ((-b - Math.Sqrt((double)(b) * (double)(b) - 4 * (double)(a) * (double)(c))) / (2 * a)).ToString();
        }
        catch (Exception e)
        {
            return e.ToString();
        }
    }

    String getHigherX()
    {
        try
        {
            return ((-b + Math.Sqrt((double)(b) * (double)(b) - 4 * (double)(a) * (double)(c))) / (2 * a)).ToString();
        }
        catch (Exception e)
        {
            return e.ToString();
        }
    }

    String getVertexX()
    {
        return "";
    }
}