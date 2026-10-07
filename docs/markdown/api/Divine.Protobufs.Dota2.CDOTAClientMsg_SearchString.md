# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString"></a> Class CDOTAClientMsg\_SearchString

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_SearchString : IMessage<CDOTAClientMsg_SearchString>, IEquatable<CDOTAClientMsg_SearchString>, IDeepCloneable<CDOTAClientMsg_SearchString>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_SearchString](Divine.Protobufs.Dota2.CDOTAClientMsg\_SearchString.md)

#### Implements

IMessage<CDOTAClientMsg\_SearchString\>, 
[IEquatable<CDOTAClientMsg\_SearchString\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_SearchString\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_SearchString\>\(CDOTAClientMsg\_SearchString, params CDOTAClientMsg\_SearchString\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString__ctor"></a> CDOTAClientMsg\_SearchString\(\)

```csharp
public CDOTAClientMsg_SearchString()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString_"></a> CDOTAClientMsg\_SearchString\(CDOTAClientMsg\_SearchString\)

```csharp
public CDOTAClientMsg_SearchString(CDOTAClientMsg_SearchString other)
```

#### Parameters

`other` [CDOTAClientMsg\_SearchString](Divine.Protobufs.Dota2.CDOTAClientMsg\_SearchString.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString_SearchFieldNumber"></a> SearchFieldNumber

```csharp
public const int SearchFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString_HasSearch"></a> HasSearch

```csharp
public bool HasSearch { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_SearchString> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_SearchString](Divine.Protobufs.Dota2.CDOTAClientMsg\_SearchString.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString_Search"></a> Search

```csharp
public string Search { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString_ClearSearch"></a> ClearSearch\(\)

```csharp
public void ClearSearch()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_SearchString Clone()
```

#### Returns

 [CDOTAClientMsg\_SearchString](Divine.Protobufs.Dota2.CDOTAClientMsg\_SearchString.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString_"></a> Equals\(CDOTAClientMsg\_SearchString\)

```csharp
public bool Equals(CDOTAClientMsg_SearchString other)
```

#### Parameters

`other` [CDOTAClientMsg\_SearchString](Divine.Protobufs.Dota2.CDOTAClientMsg\_SearchString.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString_"></a> MergeFrom\(CDOTAClientMsg\_SearchString\)

```csharp
public void MergeFrom(CDOTAClientMsg_SearchString other)
```

#### Parameters

`other` [CDOTAClientMsg\_SearchString](Divine.Protobufs.Dota2.CDOTAClientMsg\_SearchString.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SearchString_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

