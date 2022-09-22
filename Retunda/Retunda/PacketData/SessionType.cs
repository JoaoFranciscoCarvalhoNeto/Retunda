﻿namespace Retunda.PacketData;

public enum SessionType : byte
{
    Unknown = 0,
    P1 = 1,
    P2 = 2,
    P3 = 3,
    ShortP = 4,
    Q1 = 5,
    Q2 = 6,
    Q3 = 7,
    ShortQ = 8,
    OneShotQ = 9,
    Race = 10,
    R2 = 11,
    R3 = 12,
    TimeTrial = 13,
}