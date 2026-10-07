# <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts"></a> Class CMsgAMFindAccounts

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAMFindAccounts : IMessage<CMsgAMFindAccounts>, IEquatable<CMsgAMFindAccounts>, IDeepCloneable<CMsgAMFindAccounts>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAMFindAccounts](Divine.Protobufs.Steam.CMsgAMFindAccounts.md)

#### Implements

IMessage<CMsgAMFindAccounts\>, 
[IEquatable<CMsgAMFindAccounts\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAMFindAccounts\>, 
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
[EnumerableExtensions.In<CMsgAMFindAccounts\>\(CMsgAMFindAccounts, params CMsgAMFindAccounts\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts__ctor"></a> CMsgAMFindAccounts\(\)

```csharp
public CMsgAMFindAccounts()
```

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts__ctor_Divine_Protobufs_Steam_CMsgAMFindAccounts_"></a> CMsgAMFindAccounts\(CMsgAMFindAccounts\)

```csharp
public CMsgAMFindAccounts(CMsgAMFindAccounts other)
```

#### Parameters

`other` [CMsgAMFindAccounts](Divine.Protobufs.Steam.CMsgAMFindAccounts.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts_SearchStringFieldNumber"></a> SearchStringFieldNumber

```csharp
public const int SearchStringFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts_SearchTypeFieldNumber"></a> SearchTypeFieldNumber

```csharp
public const int SearchTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts_HasSearchString"></a> HasSearchString

```csharp
public bool HasSearchString { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts_HasSearchType"></a> HasSearchType

```csharp
public bool HasSearchType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAMFindAccounts> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAMFindAccounts](Divine.Protobufs.Steam.CMsgAMFindAccounts.md)\>

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts_SearchString"></a> SearchString

```csharp
public string SearchString { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts_SearchType"></a> SearchType

```csharp
public uint SearchType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts_ClearSearchString"></a> ClearSearchString\(\)

```csharp
public void ClearSearchString()
```

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts_ClearSearchType"></a> ClearSearchType\(\)

```csharp
public void ClearSearchType()
```

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts_Clone"></a> Clone\(\)

```csharp
public CMsgAMFindAccounts Clone()
```

#### Returns

 [CMsgAMFindAccounts](Divine.Protobufs.Steam.CMsgAMFindAccounts.md)

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts_Equals_Divine_Protobufs_Steam_CMsgAMFindAccounts_"></a> Equals\(CMsgAMFindAccounts\)

```csharp
public bool Equals(CMsgAMFindAccounts other)
```

#### Parameters

`other` [CMsgAMFindAccounts](Divine.Protobufs.Steam.CMsgAMFindAccounts.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts_MergeFrom_Divine_Protobufs_Steam_CMsgAMFindAccounts_"></a> MergeFrom\(CMsgAMFindAccounts\)

```csharp
public void MergeFrom(CMsgAMFindAccounts other)
```

#### Parameters

`other` [CMsgAMFindAccounts](Divine.Protobufs.Steam.CMsgAMFindAccounts.md)

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccounts_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

