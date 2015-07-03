<h1><a id="user-content-variables-data-expressions-and-constants-homework" class="anchor" href="#variables-data-expressions-and-constants-homework" aria-hidden="true"><span class="octicon octicon-link"></span></a>Variables, Data, Expressions and Constants Homework</h1>

<h2><a id="user-content-task-1-class-size-in-c" class="anchor" href="#task-1-class-size-in-c" aria-hidden="true"><span class="octicon octicon-link"></span></a>Task 1. Class Size in C#</h2>

<ul>
<li><p>Refactor the following code to use proper variable naming and simplified expressions:</p>

<pre><code>public class Size
{
    public double wIdTh, Viso4ina;
    public Size(double w, double h)
    {
        this.wIdTh = w;
        this.Viso4ina = h;
    }

    public static Size GetRotatedSize(
        Size s, double angleOfTheFigureThatWillBeRotaed)
    {
        return new Size(
            Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.wIdTh + 
                Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.Viso4ina,
            Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.wIdTh + 
                Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.Viso4ina);
    }
}
</code></pre></li>
</ul>

<h2><a id="user-content-task-2-method-printstatistics-in-c" class="anchor" href="#task-2-method-printstatistics-in-c" aria-hidden="true"><span class="octicon octicon-link"></span></a>Task 2. Method PrintStatistics in C#</h2>

<ul>
<li><p>Refactor the following code to apply variable usage and naming best practices:</p>

<pre><code>public void PrintStatistics(double[] arr, int count)
{
    double max, tmp;
    for (int i = 0; i &lt; count; i++)
    {
        if (arr[i] &gt; max)
        {
            max = arr[i];
        }
    }
    PrintMax(max);
    tmp = 0;
    max = 0;
    for (int i = 0; i &lt; count; i++)
    {
        if (arr[i] &lt; max)
        {
            max = arr[i];
        }
    }
    PrintMin(max);

    tmp = 0;
    for (int i = 0; i &lt; count; i++)
    {
        tmp += arr[i];
    }
    PrintAvg(tmp/count);
}
</code></pre></li>
</ul>