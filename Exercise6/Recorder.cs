public class CompositeRecorder
{
  private List<IRecorder> Recorders {get;} => new List <IRecorder> ();
  public void Append (IRecorder aRecorder) { Recorders.Add(aRecorder); }
  public void Remove (IRecorder aRecorder) { Recorders.Remove(aRecorder); }
  
  public void Write (string aMessage)
  {
    foreach (var r in Recorders)
      r.Write (aMessage);
  }
  
}

interface IRecorder
{
  void Write (string aMessage);
}

// main

IRecorder R1 = new FileRecorder ("My.log");
IRecorder R2 = new BDRecorder (.connectionstring);
composite Recorder R3 = new CompositeRecorder();
R3.Append (R1);
R3.Append (R2);
Logger.Instance.Recorder = new DateDecorater (R3);
Logger.Instance.Recorder = new NullRecorder ();
