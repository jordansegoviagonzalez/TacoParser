using System;
//'using System;' imports the System namespace which contrins fundamentals classes.
//The 'LogginKata' namespace is where entire project is contrained
//
namespace LoggingKata
// namespace is where we hold the project 
// LogginKata is the nameo the file
{
    public class TacoBell : ITrackable
    { //'public' means this class can be accessed from other classes and projects.
         //'TacoBell' is trhe name of the class.
         // 'ITrackable' is an interface that the TacoBell class implements. This means TacoBell must provide the methods defined in ITrackable.
         
        public string Name { get; set; }
        public Point Location { get; set; }

        public TacoBell(string name, Point location)
        {
            Name = name;
            Location = location;
        }
    }
   
  
}