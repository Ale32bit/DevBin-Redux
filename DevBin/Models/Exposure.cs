﻿namespace DevBin.Models;

public class Exposure
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsListed { get; set; }
    public bool RequireLogin { get; set; }
    public bool IsAuthorOnly { get; set; }
}