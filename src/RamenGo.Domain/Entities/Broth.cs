﻿namespace RamenGo.Domain.Entities;
public class Broth
{
    public string Id { get; set; } = string.Empty;
    public string ImageInactive { get; set; } = string.Empty;
    public string ImageActive { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
