# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage"></a> Class CMsgClientToGCSetFavoritePage

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSetFavoritePage : IMessage<CMsgClientToGCSetFavoritePage>, IEquatable<CMsgClientToGCSetFavoritePage>, IDeepCloneable<CMsgClientToGCSetFavoritePage>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSetFavoritePage](Divine.Protobufs.Dota2.CMsgClientToGCSetFavoritePage.md)

#### Implements

IMessage<CMsgClientToGCSetFavoritePage\>, 
[IEquatable<CMsgClientToGCSetFavoritePage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSetFavoritePage\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSetFavoritePage\>\(CMsgClientToGCSetFavoritePage, params CMsgClientToGCSetFavoritePage\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage__ctor"></a> CMsgClientToGCSetFavoritePage\(\)

```csharp
public CMsgClientToGCSetFavoritePage()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_"></a> CMsgClientToGCSetFavoritePage\(CMsgClientToGCSetFavoritePage\)

```csharp
public CMsgClientToGCSetFavoritePage(CMsgClientToGCSetFavoritePage other)
```

#### Parameters

`other` [CMsgClientToGCSetFavoritePage](Divine.Protobufs.Dota2.CMsgClientToGCSetFavoritePage.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_ClearFieldNumber"></a> ClearFieldNumber

```csharp
public const int ClearFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_PageNumFieldNumber"></a> PageNumFieldNumber

```csharp
public const int PageNumFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_Clear"></a> Clear

```csharp
public bool Clear { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_HasClear"></a> HasClear

```csharp
public bool HasClear { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_HasPageNum"></a> HasPageNum

```csharp
public bool HasPageNum { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_PageNum"></a> PageNum

```csharp
public uint PageNum { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSetFavoritePage> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSetFavoritePage](Divine.Protobufs.Dota2.CMsgClientToGCSetFavoritePage.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_ClearClear"></a> ClearClear\(\)

```csharp
public void ClearClear()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_ClearPageNum"></a> ClearPageNum\(\)

```csharp
public void ClearPageNum()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSetFavoritePage Clone()
```

#### Returns

 [CMsgClientToGCSetFavoritePage](Divine.Protobufs.Dota2.CMsgClientToGCSetFavoritePage.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_"></a> Equals\(CMsgClientToGCSetFavoritePage\)

```csharp
public bool Equals(CMsgClientToGCSetFavoritePage other)
```

#### Parameters

`other` [CMsgClientToGCSetFavoritePage](Divine.Protobufs.Dota2.CMsgClientToGCSetFavoritePage.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_"></a> MergeFrom\(CMsgClientToGCSetFavoritePage\)

```csharp
public void MergeFrom(CMsgClientToGCSetFavoritePage other)
```

#### Parameters

`other` [CMsgClientToGCSetFavoritePage](Divine.Protobufs.Dota2.CMsgClientToGCSetFavoritePage.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetFavoritePage_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

