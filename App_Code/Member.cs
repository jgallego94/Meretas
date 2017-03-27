using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Member
/// </summary>
public class Member
{
    private string memberIDValue;
    private int isAdminValue;

    public string memberID
    {
        get { return memberIDValue; }
        set { memberIDValue = value; }
    }

    public int isAdmin
    {
        get { return isAdminValue; }
        set { isAdminValue = value; }
    }
}