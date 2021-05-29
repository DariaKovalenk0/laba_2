using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Logger
{
    private static Logger logger = null;
    private string _information;
    protected Logger()
    {
        _information = "";
    }
    public void WriteLine(string s)
    {

        _information += s + " ";
    }
    public void WriteNumber(int a)
    {
        _information += a.ToString() + " ";
    }
    public static Logger Initialize()
    {
        if (logger == null)
            logger = new Logger();
        return logger;
    }

    public string Information
    {
        get => _information;

    }
    public void Delete()
    {
        _information = "";
    }
}