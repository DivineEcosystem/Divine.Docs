# <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket"></a> Class CEngineGotvSyncPacket

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CEngineGotvSyncPacket : IMessage<CEngineGotvSyncPacket>, IEquatable<CEngineGotvSyncPacket>, IDeepCloneable<CEngineGotvSyncPacket>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CEngineGotvSyncPacket](Divine.Protobufs.Dota2.CEngineGotvSyncPacket.md)

#### Implements

IMessage<CEngineGotvSyncPacket\>, 
[IEquatable<CEngineGotvSyncPacket\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CEngineGotvSyncPacket\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CEngineGotvSyncPacket\>\(CEngineGotvSyncPacket, params CEngineGotvSyncPacket\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket__ctor"></a> CEngineGotvSyncPacket\(\)

```csharp
public CEngineGotvSyncPacket()
```

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket__ctor_Divine_Protobufs_Dota2_CEngineGotvSyncPacket_"></a> CEngineGotvSyncPacket\(CEngineGotvSyncPacket\)

```csharp
public CEngineGotvSyncPacket(CEngineGotvSyncPacket other)
```

#### Parameters

`other` [CEngineGotvSyncPacket](Divine.Protobufs.Dota2.CEngineGotvSyncPacket.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_CdndelayFieldNumber"></a> CdndelayFieldNumber

```csharp
public const int CdndelayFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_CurrentfragmentFieldNumber"></a> CurrentfragmentFieldNumber

```csharp
public const int CurrentfragmentFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_InstanceIdFieldNumber"></a> InstanceIdFieldNumber

```csharp
public const int InstanceIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_KeyframeIntervalFieldNumber"></a> KeyframeIntervalFieldNumber

```csharp
public const int KeyframeIntervalFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_RcvageFieldNumber"></a> RcvageFieldNumber

```csharp
public const int RcvageFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_RtdelayFieldNumber"></a> RtdelayFieldNumber

```csharp
public const int RtdelayFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_SignupfragmentFieldNumber"></a> SignupfragmentFieldNumber

```csharp
public const int SignupfragmentFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_TickFieldNumber"></a> TickFieldNumber

```csharp
public const int TickFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_TickrateFieldNumber"></a> TickrateFieldNumber

```csharp
public const int TickrateFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_Cdndelay"></a> Cdndelay

```csharp
public uint Cdndelay { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_Currentfragment"></a> Currentfragment

```csharp
public uint Currentfragment { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_HasCdndelay"></a> HasCdndelay

```csharp
public bool HasCdndelay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_HasCurrentfragment"></a> HasCurrentfragment

```csharp
public bool HasCurrentfragment { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_HasInstanceId"></a> HasInstanceId

```csharp
public bool HasInstanceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_HasKeyframeInterval"></a> HasKeyframeInterval

```csharp
public bool HasKeyframeInterval { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_HasRcvage"></a> HasRcvage

```csharp
public bool HasRcvage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_HasRtdelay"></a> HasRtdelay

```csharp
public bool HasRtdelay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_HasSignupfragment"></a> HasSignupfragment

```csharp
public bool HasSignupfragment { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_HasTick"></a> HasTick

```csharp
public bool HasTick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_HasTickrate"></a> HasTickrate

```csharp
public bool HasTickrate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_InstanceId"></a> InstanceId

```csharp
public uint InstanceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_KeyframeInterval"></a> KeyframeInterval

```csharp
public float KeyframeInterval { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_Parser"></a> Parser

```csharp
public static MessageParser<CEngineGotvSyncPacket> Parser { get; }
```

#### Property Value

 MessageParser<[CEngineGotvSyncPacket](Divine.Protobufs.Dota2.CEngineGotvSyncPacket.md)\>

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_Rcvage"></a> Rcvage

```csharp
public float Rcvage { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_Rtdelay"></a> Rtdelay

```csharp
public float Rtdelay { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_Signupfragment"></a> Signupfragment

```csharp
public uint Signupfragment { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_Tick"></a> Tick

```csharp
public uint Tick { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_Tickrate"></a> Tickrate

```csharp
public float Tickrate { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_ClearCdndelay"></a> ClearCdndelay\(\)

```csharp
public void ClearCdndelay()
```

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_ClearCurrentfragment"></a> ClearCurrentfragment\(\)

```csharp
public void ClearCurrentfragment()
```

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_ClearInstanceId"></a> ClearInstanceId\(\)

```csharp
public void ClearInstanceId()
```

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_ClearKeyframeInterval"></a> ClearKeyframeInterval\(\)

```csharp
public void ClearKeyframeInterval()
```

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_ClearRcvage"></a> ClearRcvage\(\)

```csharp
public void ClearRcvage()
```

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_ClearRtdelay"></a> ClearRtdelay\(\)

```csharp
public void ClearRtdelay()
```

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_ClearSignupfragment"></a> ClearSignupfragment\(\)

```csharp
public void ClearSignupfragment()
```

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_ClearTick"></a> ClearTick\(\)

```csharp
public void ClearTick()
```

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_ClearTickrate"></a> ClearTickrate\(\)

```csharp
public void ClearTickrate()
```

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_Clone"></a> Clone\(\)

```csharp
public CEngineGotvSyncPacket Clone()
```

#### Returns

 [CEngineGotvSyncPacket](Divine.Protobufs.Dota2.CEngineGotvSyncPacket.md)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_Equals_Divine_Protobufs_Dota2_CEngineGotvSyncPacket_"></a> Equals\(CEngineGotvSyncPacket\)

```csharp
public bool Equals(CEngineGotvSyncPacket other)
```

#### Parameters

`other` [CEngineGotvSyncPacket](Divine.Protobufs.Dota2.CEngineGotvSyncPacket.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_MergeFrom_Divine_Protobufs_Dota2_CEngineGotvSyncPacket_"></a> MergeFrom\(CEngineGotvSyncPacket\)

```csharp
public void MergeFrom(CEngineGotvSyncPacket other)
```

#### Parameters

`other` [CEngineGotvSyncPacket](Divine.Protobufs.Dota2.CEngineGotvSyncPacket.md)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CEngineGotvSyncPacket_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

