using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class heartrateData : trackedDataSource 
{
    override protected void filter()
    {
        rawData = dataSource.lastLine;
        List<string> dataList = rawData.Split(',').ToList<string>();
        float.TryParse(dataList[0], out cleanData);
    }
}
