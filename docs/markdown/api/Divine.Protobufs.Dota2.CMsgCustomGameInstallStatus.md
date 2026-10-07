# <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus"></a> Class CMsgCustomGameInstallStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgCustomGameInstallStatus : IMessage<CMsgCustomGameInstallStatus>, IEquatable<CMsgCustomGameInstallStatus>, IDeepCloneable<CMsgCustomGameInstallStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgCustomGameInstallStatus](Divine.Protobufs.Dota2.CMsgCustomGameInstallStatus.md)

#### Implements

IMessage<CMsgCustomGameInstallStatus\>, 
[IEquatable<CMsgCustomGameInstallStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgCustomGameInstallStatus\>, 
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
[EnumerableExtensions.In<CMsgCustomGameInstallStatus\>\(CMsgCustomGameInstallStatus, params CMsgCustomGameInstallStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus__ctor"></a> CMsgCustomGameInstallStatus\(\)

```csharp
public CMsgCustomGameInstallStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus__ctor_Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_"></a> CMsgCustomGameInstallStatus\(CMsgCustomGameInstallStatus\)

```csharp
public CMsgCustomGameInstallStatus(CMsgCustomGameInstallStatus other)
```

#### Parameters

`other` [CMsgCustomGameInstallStatus](Divine.Protobufs.Dota2.CMsgCustomGameInstallStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_LatestTimestampFromSteamFieldNumber"></a> LatestTimestampFromSteamFieldNumber

```csharp
public const int LatestTimestampFromSteamFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_MessageFieldNumber"></a> MessageFieldNumber

```csharp
public const int MessageFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_StatusFieldNumber"></a> StatusFieldNumber

```csharp
public const int StatusFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_HasLatestTimestampFromSteam"></a> HasLatestTimestampFromSteam

```csharp
public bool HasLatestTimestampFromSteam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_HasMessage"></a> HasMessage

```csharp
public bool HasMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_HasStatus"></a> HasStatus

```csharp
public bool HasStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_LatestTimestampFromSteam"></a> LatestTimestampFromSteam

```csharp
public uint LatestTimestampFromSteam { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_Message"></a> Message

```csharp
public string Message { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgCustomGameInstallStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgCustomGameInstallStatus](Divine.Protobufs.Dota2.CMsgCustomGameInstallStatus.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_Status"></a> Status

```csharp
public ECustomGameInstallStatus Status { get; set; }
```

#### Property Value

 [ECustomGameInstallStatus](Divine.Protobufs.Dota2.ECustomGameInstallStatus.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_ClearLatestTimestampFromSteam"></a> ClearLatestTimestampFromSteam\(\)

```csharp
public void ClearLatestTimestampFromSteam()
```

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_ClearMessage"></a> ClearMessage\(\)

```csharp
public void ClearMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_ClearStatus"></a> ClearStatus\(\)

```csharp
public void ClearStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_Clone"></a> Clone\(\)

```csharp
public CMsgCustomGameInstallStatus Clone()
```

#### Returns

 [CMsgCustomGameInstallStatus](Divine.Protobufs.Dota2.CMsgCustomGameInstallStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_Equals_Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_"></a> Equals\(CMsgCustomGameInstallStatus\)

```csharp
public bool Equals(CMsgCustomGameInstallStatus other)
```

#### Parameters

`other` [CMsgCustomGameInstallStatus](Divine.Protobufs.Dota2.CMsgCustomGameInstallStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_MergeFrom_Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_"></a> MergeFrom\(CMsgCustomGameInstallStatus\)

```csharp
public void MergeFrom(CMsgCustomGameInstallStatus other)
```

#### Parameters

`other` [CMsgCustomGameInstallStatus](Divine.Protobufs.Dota2.CMsgCustomGameInstallStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgCustomGameInstallStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

