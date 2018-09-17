using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using GeoJSON;
using System.Drawing;


public class Properties
{
    public object NID_fi { get; set; }
    public object NID_sv { get; set; }
    public object NID_en { get; set; }
    public string Tyyppi { get; set; }
    public string Name_fi { get; set; }
    public string Name_sv { get; set; }
    public string Name_en { get; set; }
    public string Address_fi { get; set; }
    public string Address_sv { get; set; }
    public string Address_en { get; set; }
    public object Postal_code { get; set; }
    public string City_fi { get; set; }
    public string City_sv { get; set; }
    public string City_en { get; set; }
    public string Address_help_fi { get; set; }
    public string Address_help_sv { get; set; }
    public string Address_help_en { get; set; }
    public string Additional_information_fi { get; set; }
    public string Additional_information_sv { get; set; }
    public string Additional_information_en { get; set; }
    public object LAT { get; set; }
    public object LON { get; set; }
    public string Neighbourhood { get; set; }
    public string Zone { get; set; }
    public int OBJECTID { get; set; }
}

public class Geometry
{
    public string type { get; set; }
    public List<double> coordinates { get; set; }
}

public class Feature
{
    public string type { get; set; }
    public Properties properties { get; set; }
    public Geometry geometry { get; set; }
}

public class HSL_locations
{
    public string type { get; set; }
    public List<Feature> features { get; set; }
}