<h1><a id="user-content-control-flow-conditional-statements-and-loops-homework" class="anchor" href="#control-flow-conditional-statements-and-loops-homework" aria-hidden="true"><span class="octicon octicon-link"></span></a>Control Flow, Conditional Statements and Loops Homework</h1>

<h2><a id="user-content-task-1-class-chef-in-c" class="anchor" href="#task-1-class-chef-in-c" aria-hidden="true"><span class="octicon octicon-link"></span></a>Task 1. Class Chef in C#</h2>

<ul>
<li><p>Refactor the following class using best practices for organizing straight-line code:</p>

<pre><code>public class Chef
{
    private Bowl GetBowl()
    {   
        //... 
    }
    private Carrot GetCarrot()
    {
        //...
    }
    private void Cut(Vegetable potato)
    {
        //...
    }  
    public void Cook()
    {
        Potato potato = GetPotato();
        Carrot carrot = GetCarrot();
        Bowl bowl;
        Peel(potato);

        Peel(carrot);
        bowl = GetBowl();
        Cut(potato);
        Cut(carrot);
        bowl.Add(carrot);

        bowl.Add(potato);
    }
    private Potato GetPotato()
    {
        //...
    }
}
</code></pre></li>
</ul>

<h2><a id="user-content-task-2-refactor-the-following-if-statements" class="anchor" href="#task-2-refactor-the-following-if-statements" aria-hidden="true"><span class="octicon octicon-link"></span></a>Task 2. Refactor the following if statements</h2>

<pre><code>Potato potato;
//... 
if (potato != null)
   if(!potato.HasNotBeenPeeled &amp;&amp; !potato.IsRotten)
    Cook(potato);
</code></pre>

<p>and</p>

<pre><code>if (x &gt;= MIN_X &amp;&amp; (x =&lt; MAX_X &amp;&amp; ((MAX_Y &gt;= y &amp;&amp; MIN_Y &lt;= y) &amp;&amp; !shouldNotVisitCell)))
{
   VisitCell();
}
</code></pre>

<h2><a id="user-content-task-3-refactor-the-following-loop" class="anchor" href="#task-3-refactor-the-following-loop" aria-hidden="true"><span class="octicon octicon-link"></span></a>Task 3. Refactor the following loop</h2>

<pre><code>int i=0;
for (i = 0; i &lt; 100;) 
{
   if (i % 10 == 0)
   {
    Console.WriteLine(array[i]);
    if ( array[i] == expectedValue ) 
    {
       i = 666;
    }
    i++;
   }
   else
   {
        Console.WriteLine(array[i]);
    i++;
   }
}
// More code here
if (i == 666)
{
    Console.WriteLine("Value Found");
}
</code></pre>

<h2><a id="user-content-task-4-refactor-your-c-1-exam-solutions" class="anchor" href="#task-4-refactor-your-c-1-exam-solutions" aria-hidden="true"><span class="octicon octicon-link"></span></a>Task 4*. Refactor your C# 1 exam solutions</h2>

<ul>
<li>  Using best practices for Variables, Data, Expressions, Constants, Control Flow, Conditional Statements and Loops refactor all your solutions sent during the first C# practical exam this year</li>
</ul>