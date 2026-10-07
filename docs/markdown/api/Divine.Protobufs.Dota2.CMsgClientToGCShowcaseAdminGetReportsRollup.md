# <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup"></a> Class CMsgClientToGCShowcaseAdminGetReportsRollup

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCShowcaseAdminGetReportsRollup : IMessage<CMsgClientToGCShowcaseAdminGetReportsRollup>, IEquatable<CMsgClientToGCShowcaseAdminGetReportsRollup>, IDeepCloneable<CMsgClientToGCShowcaseAdminGetReportsRollup>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCShowcaseAdminGetReportsRollup](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetReportsRollup.md)

#### Implements

IMessage<CMsgClientToGCShowcaseAdminGetReportsRollup\>, 
[IEquatable<CMsgClientToGCShowcaseAdminGetReportsRollup\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCShowcaseAdminGetReportsRollup\>, 
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
[EnumerableExtensions.In<CMsgClientToGCShowcaseAdminGetReportsRollup\>\(CMsgClientToGCShowcaseAdminGetReportsRollup, params CMsgClientToGCShowcaseAdminGetReportsRollup\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup__ctor"></a> CMsgClientToGCShowcaseAdminGetReportsRollup\(\)

```csharp
public CMsgClientToGCShowcaseAdminGetReportsRollup()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup__ctor_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup_"></a> CMsgClientToGCShowcaseAdminGetReportsRollup\(CMsgClientToGCShowcaseAdminGetReportsRollup\)

```csharp
public CMsgClientToGCShowcaseAdminGetReportsRollup(CMsgClientToGCShowcaseAdminGetReportsRollup other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminGetReportsRollup](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetReportsRollup.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup_RollupIdFieldNumber"></a> RollupIdFieldNumber

```csharp
public const int RollupIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup_HasRollupId"></a> HasRollupId

```csharp
public bool HasRollupId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCShowcaseAdminGetReportsRollup> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCShowcaseAdminGetReportsRollup](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetReportsRollup.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup_RollupId"></a> RollupId

```csharp
public uint RollupId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup_ClearRollupId"></a> ClearRollupId\(\)

```csharp
public void ClearRollupId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCShowcaseAdminGetReportsRollup Clone()
```

#### Returns

 [CMsgClientToGCShowcaseAdminGetReportsRollup](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetReportsRollup.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup_Equals_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup_"></a> Equals\(CMsgClientToGCShowcaseAdminGetReportsRollup\)

```csharp
public bool Equals(CMsgClientToGCShowcaseAdminGetReportsRollup other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminGetReportsRollup](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetReportsRollup.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup_"></a> MergeFrom\(CMsgClientToGCShowcaseAdminGetReportsRollup\)

```csharp
public void MergeFrom(CMsgClientToGCShowcaseAdminGetReportsRollup other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminGetReportsRollup](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetReportsRollup.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollup_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

