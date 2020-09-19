using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seanca1Ikub
{
  class Taxpayer
  {
    private int SSNr;
    private float income;
    public readonly float taxOwed; 

    public int ssnr
    {
      get { return SSNr; }
      set { SSNr = value; }
    }

    public float Income
    {
      get { return income; }
      set { income = value; }
    }

    //public float TaxOwed
    //{
    //  get { return TaxOwed; }
    //}

    public Taxpayer(int ssnr, float inc)
    {
      SSNr = ssnr;
      income = inc;
      if (inc < 30000)
      {
        taxOwed = (float)0.15 * inc;
      }
      else
      {
        taxOwed = (float)0.28 * inc;
      }
    }
  }
}
