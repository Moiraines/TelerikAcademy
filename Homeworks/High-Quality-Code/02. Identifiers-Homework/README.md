<body>
<h1>Naming Identifiers Homework</h1>

<h2><a id="user-content-homework" class="anchor" href="#homework" aria-hidden="true"><span class="octicon octicon-link"></span></a>Homework</h2>

<h3><a id="user-content-task-1-class_123-in-c" class="anchor" href="#task-1-class_123-in-c" aria-hidden="true"><span class="octicon octicon-link"></span></a>Task 1. class_123 in C#</h3>

<ul>
<li><p>Refactor the following examples to produce code with well-named C# identifiers.</p>

<pre><code>class class_123
{
  const int max_count=6;
  class InClass_class_123
  {
    void Метод_нА_class_InClass_class_123(bool promenliva)
    {
      string promenlivaKatoString=promenliva.ToString();
      Console.WriteLine(promenlivaKatoString);
      }
  }       
  public static void Метод_За_Вход()
  {
    class_123.InClass_class_123 инстанция =
      new class_123.InClass_class_123();
    инстанция.Метод_нА_class_InClass_class_123(true); 
  }
}
</code></pre></li>
</ul>

<h3><a id="user-content-task-2-make_Чуек-in-c" class="anchor" href="#task-2-make_Чуек-in-c" aria-hidden="true"><span class="octicon octicon-link"></span></a>Task 2. Make_Чуек in C#</h3>

<ul>
<li><p>Refactor the following examples to produce code with well-named C# identifiers.</p>

<pre><code>class Hauptklasse
{
  enum Пол { ултра_Батка, Яка_Мацка };
  class чуек
  {
    public Пол пол { get; set; }
    public string име_на_Чуека { get; set; }
    public int Възраст { get; set; }
  }       
  public void Make_Чуек(int магическия_НомерНаЕДИНЧОВЕК)
  {
    чуек new_Чуек = new чуек();
    new_Чуек.Възраст = магическия_НомерНаЕДИНЧОВЕК;
    if (магическия_НомерНаЕДИНЧОВЕК%2 == 0)
    {
      new_Чуек.име_на_Чуека = "Батката";
      new_Чуек.пол = Пол.ултра_Батка;
    }
    else
    {
      new_Чуек.име_на_Чуека = "Мацето";
      new_Чуек.пол = Пол.Яка_Мацка;
    }
  }
}
</code></pre></li>
</ul>

<h3><a id="user-content-task-3-_clickon_thebutton-in-javascript" class="anchor" href="#task-3-_clickon_thebutton-in-javascript" aria-hidden="true"><span class="octicon octicon-link"></span></a>Task 3. _ClickON_TheButton in JavaScript</h3>

<ul>
<li><p>Refactor the following examples to produce code with well-named identifiers in JavaScript</p>

<pre><code>function _ClickON_TheButton( THE_event, argumenti) {
  var moqProzorec= window,
      brauzyra = moqProzorec.navigator.appCodeName,
      ism=brauzyra=="Mozilla";
  if(ism) {
    alert("Yes");
  } else {
    alert("No");
  }
}
</code></pre></li>
</ul>

<h3><a id="user-content-task-4-re-factor-and-improve-the-code" class="anchor" href="#task-4-re-factor-and-improve-the-code" aria-hidden="true"><span class="octicon octicon-link"></span></a>Task 4. Re-factor and improve the code</h3>

<ul>
<li>  Refactor and improve the naming in the C# source project <code>Application1.sln</code>.</li>
<li>  You are allowed to make other improvements in the code as well (not only naming) as well as to fix bugs.</li>
</ul>    
  </body>
</html>

