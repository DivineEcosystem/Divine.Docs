# <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus"></a> Class CMsgTeamFanContentAutographStatus.Types.AutographStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTeamFanContentAutographStatus.Types.AutographStatus : IMessage<CMsgTeamFanContentAutographStatus.Types.AutographStatus>, IEquatable<CMsgTeamFanContentAutographStatus.Types.AutographStatus>, IDeepCloneable<CMsgTeamFanContentAutographStatus.Types.AutographStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTeamFanContentAutographStatus.Types.AutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.AutographStatus.md)

#### Implements

IMessage<CMsgTeamFanContentAutographStatus.Types.AutographStatus\>, 
[IEquatable<CMsgTeamFanContentAutographStatus.Types.AutographStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTeamFanContentAutographStatus.Types.AutographStatus\>, 
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
[EnumerableExtensions.In<CMsgTeamFanContentAutographStatus.Types.AutographStatus\>\(CMsgTeamFanContentAutographStatus.Types.AutographStatus, params CMsgTeamFanContentAutographStatus.Types.AutographStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus__ctor"></a> AutographStatus\(\)

```csharp
public AutographStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus__ctor_Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_"></a> AutographStatus\(AutographStatus\)

```csharp
public AutographStatus(CMsgTeamFanContentAutographStatus.Types.AutographStatus other)
```

#### Parameters

`other` [CMsgTeamFanContentAutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.md).[AutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.AutographStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_FileFieldNumber"></a> FileFieldNumber

```csharp
public const int FileFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_ProNameFieldNumber"></a> ProNameFieldNumber

```csharp
public const int ProNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_File"></a> File

```csharp
public string File { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_HasFile"></a> HasFile

```csharp
public bool HasFile { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_HasProName"></a> HasProName

```csharp
public bool HasProName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTeamFanContentAutographStatus.Types.AutographStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTeamFanContentAutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.md).[AutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.AutographStatus.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_ProName"></a> ProName

```csharp
public string ProName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_ClearFile"></a> ClearFile\(\)

```csharp
public void ClearFile()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_ClearProName"></a> ClearProName\(\)

```csharp
public void ClearProName()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_Clone"></a> Clone\(\)

```csharp
public CMsgTeamFanContentAutographStatus.Types.AutographStatus Clone()
```

#### Returns

 [CMsgTeamFanContentAutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.md).[AutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.AutographStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_Equals_Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_"></a> Equals\(AutographStatus\)

```csharp
public bool Equals(CMsgTeamFanContentAutographStatus.Types.AutographStatus other)
```

#### Parameters

`other` [CMsgTeamFanContentAutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.md).[AutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.AutographStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_MergeFrom_Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_"></a> MergeFrom\(AutographStatus\)

```csharp
public void MergeFrom(CMsgTeamFanContentAutographStatus.Types.AutographStatus other)
```

#### Parameters

`other` [CMsgTeamFanContentAutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.md).[AutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.AutographStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Types_AutographStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

