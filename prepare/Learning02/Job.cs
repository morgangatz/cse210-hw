public class Job {
    public string _jobTitle = "";
    public string _company = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public string GetJobTitle(){
        return _jobTitle;
    }
    public string GetCompany(){
        return _company;
    }
    public int GetStartYear(){
        return _startYear;
    }
    public int GetEndYear(){
        return _endYear;
    }

    public void Display(){
       Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}"); 
    }
}