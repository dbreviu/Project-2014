﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page
{

    private int i;  
    String[] ppl = { "Cassie", "Joanne", "Robert" };

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) 
        {
            i = 0;
        }
       
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        i++;
        txtBoxInput.Text = whoRules(i) +" Rules!";
    }

    public String whoRules(int i) 
    {
        
        return ppl[i];
    }

}
