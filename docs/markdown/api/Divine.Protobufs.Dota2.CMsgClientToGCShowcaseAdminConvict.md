# <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict"></a> Class CMsgClientToGCShowcaseAdminConvict

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCShowcaseAdminConvict : IMessage<CMsgClientToGCShowcaseAdminConvict>, IEquatable<CMsgClientToGCShowcaseAdminConvict>, IDeepCloneable<CMsgClientToGCShowcaseAdminConvict>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCShowcaseAdminConvict](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminConvict.md)

#### Implements

IMessage<CMsgClientToGCShowcaseAdminConvict\>, 
[IEquatable<CMsgClientToGCShowcaseAdminConvict\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCShowcaseAdminConvict\>, 
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
[EnumerableExtensions.In<CMsgClientToGCShowcaseAdminConvict\>\(CMsgClientToGCShowcaseAdminConvict, params CMsgClientToGCShowcaseAdminConvict\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict__ctor"></a> CMsgClientToGCShowcaseAdminConvict\(\)

```csharp
public CMsgClientToGCShowcaseAdminConvict()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict__ctor_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_"></a> CMsgClientToGCShowcaseAdminConvict\(CMsgClientToGCShowcaseAdminConvict\)

```csharp
public CMsgClientToGCShowcaseAdminConvict(CMsgClientToGCShowcaseAdminConvict other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminConvict](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminConvict.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_ShowcaseTypeFieldNumber"></a> ShowcaseTypeFieldNumber

```csharp
public const int ShowcaseTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_HasShowcaseType"></a> HasShowcaseType

```csharp
public bool HasShowcaseType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCShowcaseAdminConvict> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCShowcaseAdminConvict](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminConvict.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_ShowcaseType"></a> ShowcaseType

```csharp
public EShowcaseType ShowcaseType { get; set; }
```

#### Property Value

 [EShowcaseType](Divine.Protobufs.Dota2.EShowcaseType.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_ClearShowcaseType"></a> ClearShowcaseType\(\)

```csharp
public void ClearShowcaseType()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCShowcaseAdminConvict Clone()
```

#### Returns

 [CMsgClientToGCShowcaseAdminConvict](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminConvict.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_Equals_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_"></a> Equals\(CMsgClientToGCShowcaseAdminConvict\)

```csharp
public bool Equals(CMsgClientToGCShowcaseAdminConvict other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminConvict](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminConvict.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_"></a> MergeFrom\(CMsgClientToGCShowcaseAdminConvict\)

```csharp
public void MergeFrom(CMsgClientToGCShowcaseAdminConvict other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminConvict](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminConvict.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminConvict_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

