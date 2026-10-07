# <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo"></a> Class CMsgDOTAMatch.Types.BroadcasterInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAMatch.Types.BroadcasterInfo : IMessage<CMsgDOTAMatch.Types.BroadcasterInfo>, IEquatable<CMsgDOTAMatch.Types.BroadcasterInfo>, IDeepCloneable<CMsgDOTAMatch.Types.BroadcasterInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAMatch.Types.BroadcasterInfo](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.BroadcasterInfo.md)

#### Implements

IMessage<CMsgDOTAMatch.Types.BroadcasterInfo\>, 
[IEquatable<CMsgDOTAMatch.Types.BroadcasterInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAMatch.Types.BroadcasterInfo\>, 
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
[EnumerableExtensions.In<CMsgDOTAMatch.Types.BroadcasterInfo\>\(CMsgDOTAMatch.Types.BroadcasterInfo, params CMsgDOTAMatch.Types.BroadcasterInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo__ctor"></a> BroadcasterInfo\(\)

```csharp
public BroadcasterInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo__ctor_Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_"></a> BroadcasterInfo\(BroadcasterInfo\)

```csharp
public BroadcasterInfo(CMsgDOTAMatch.Types.BroadcasterInfo other)
```

#### Parameters

`other` [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[BroadcasterInfo](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.BroadcasterInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAMatch.Types.BroadcasterInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[BroadcasterInfo](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.BroadcasterInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAMatch.Types.BroadcasterInfo Clone()
```

#### Returns

 [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[BroadcasterInfo](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.BroadcasterInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_Equals_Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_"></a> Equals\(BroadcasterInfo\)

```csharp
public bool Equals(CMsgDOTAMatch.Types.BroadcasterInfo other)
```

#### Parameters

`other` [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[BroadcasterInfo](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.BroadcasterInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_"></a> MergeFrom\(BroadcasterInfo\)

```csharp
public void MergeFrom(CMsgDOTAMatch.Types.BroadcasterInfo other)
```

#### Parameters

`other` [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[BroadcasterInfo](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.BroadcasterInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

