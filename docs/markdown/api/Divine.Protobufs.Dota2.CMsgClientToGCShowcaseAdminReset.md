# <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset"></a> Class CMsgClientToGCShowcaseAdminReset

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCShowcaseAdminReset : IMessage<CMsgClientToGCShowcaseAdminReset>, IEquatable<CMsgClientToGCShowcaseAdminReset>, IDeepCloneable<CMsgClientToGCShowcaseAdminReset>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCShowcaseAdminReset](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminReset.md)

#### Implements

IMessage<CMsgClientToGCShowcaseAdminReset\>, 
[IEquatable<CMsgClientToGCShowcaseAdminReset\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCShowcaseAdminReset\>, 
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
[EnumerableExtensions.In<CMsgClientToGCShowcaseAdminReset\>\(CMsgClientToGCShowcaseAdminReset, params CMsgClientToGCShowcaseAdminReset\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset__ctor"></a> CMsgClientToGCShowcaseAdminReset\(\)

```csharp
public CMsgClientToGCShowcaseAdminReset()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset__ctor_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_"></a> CMsgClientToGCShowcaseAdminReset\(CMsgClientToGCShowcaseAdminReset\)

```csharp
public CMsgClientToGCShowcaseAdminReset(CMsgClientToGCShowcaseAdminReset other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminReset](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminReset.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_ShowcaseTypeFieldNumber"></a> ShowcaseTypeFieldNumber

```csharp
public const int ShowcaseTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_HasShowcaseType"></a> HasShowcaseType

```csharp
public bool HasShowcaseType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCShowcaseAdminReset> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCShowcaseAdminReset](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminReset.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_ShowcaseType"></a> ShowcaseType

```csharp
public EShowcaseType ShowcaseType { get; set; }
```

#### Property Value

 [EShowcaseType](Divine.Protobufs.Dota2.EShowcaseType.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_ClearShowcaseType"></a> ClearShowcaseType\(\)

```csharp
public void ClearShowcaseType()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCShowcaseAdminReset Clone()
```

#### Returns

 [CMsgClientToGCShowcaseAdminReset](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminReset.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_Equals_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_"></a> Equals\(CMsgClientToGCShowcaseAdminReset\)

```csharp
public bool Equals(CMsgClientToGCShowcaseAdminReset other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminReset](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminReset.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_"></a> MergeFrom\(CMsgClientToGCShowcaseAdminReset\)

```csharp
public void MergeFrom(CMsgClientToGCShowcaseAdminReset other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminReset](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminReset.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminReset_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

