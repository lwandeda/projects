// This class represents one job.

public class Job
{
    // These variables store information about the job.

    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    // This method displays the job information.
    // It does not return anything, so we use void.

    public void Display()
    {
        // Display the job in the required format.
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}