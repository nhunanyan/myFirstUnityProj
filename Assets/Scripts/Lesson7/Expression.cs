using System;
using System.Diagnostics;

public class Expression
{
    public float Exp1(int n)
    {
        float curront = 1f;
        float result = 0f;
        for(int i = 1; i <= n; ++i)
        {
            result += curront * curront;
            curront = 0.5f * MathF.Abs(curront - 4);
        }
        return result;
    }

    public float Exp2 (int n)
    {
        float curront = 0.5f;
        float result = 1f;

        for (int i = 1; i <= n; ++i)
        {
            result *= curront;
            curront = MathF.Tan(curront + 2);
        }
        return result;
    }

    public float Exp3 (int n)
    {
        float curront = 0.5f;
        float result = 1f;
        for (int i = 5; i <= n; ++i)
        {
            result *= (curront * curront + curront);
            curront = MathF.Log10(curront + 2);
        }
        return result;
    }

    public float Exp4 (int n)
    {
        float curront = -4.2f;
        float result = 0f;

        for (int i = 0; i <= n; ++i)
        {
            result += (curront * curront - 2 * curront);
            curront = 1 / MathF.Tan(curront);
        }
        return result;
    }

    public float Exp5 (float x)
    {
        return MathF.Log(x * x + 4, 3);
    }

    public float Exp6 (float x)
    {
        return MathF.Pow((x + x * x) , 7);
    }

    public float Exp7 (float x)
    {
        return MathF.Pow(MathF.Atan(x + 1f) ,2);
    }

    public float Exp8 (float x)
    {
        return MathF.Exp(1/MathF.Tan(x));
    }

    public float Exp9 (float x)
    {
        return MathF.Abs(2 * x + MathF.Pow(x, 3));
    }

    public void Calculate6 (float start, float end, float delta) 
    {
        for (float x = start; x <= end; x+=delta)
        {
            Console.WriteLine("x = " + x + " y = " + Exp6(x));
        }
    }

    public void Calculate7 (float start, float end, float delta) 
    {
        for (float x = start; x <= end; x+=delta)
        {
            Console.WriteLine("x = " + x + " y = " + Exp7(x));
        }
    }

    public void Calculate8 (float start, float end, float delta) 
    {
        for (float x = start; x <= end; x+=delta)
        {
            Console.WriteLine("x = " + x + " y = " + Exp8(x));
        }
    }

    public void Calculate9 (float start, float end, float delta) 
    {
        for (float x = start; x <= end; x+=delta)
        {
            Console.WriteLine("x = " + x + " y = " + Exp9(x));
        }
    }
}
