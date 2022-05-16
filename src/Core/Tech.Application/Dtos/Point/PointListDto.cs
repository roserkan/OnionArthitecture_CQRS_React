﻿using Tech.Application.Interfaces.Dto;

namespace Tech.Application.Dtos;

public class PointListDto: IDto
{
    public Guid Id { get; set; }
    public int PointValue { get; set; }
    public Guid ProductId { get; set; }
}

