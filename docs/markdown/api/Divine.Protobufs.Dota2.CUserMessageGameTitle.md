# <a id="Divine_Protobufs_Dota2_CUserMessageGameTitle"></a> Class CUserMessageGameTitle

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageGameTitle : IMessage<CUserMessageGameTitle>, IEquatable<CUserMessageGameTitle>, IDeepCloneable<CUserMessageGameTitle>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageGameTitle](Divine.Protobufs.Dota2.CUserMessageGameTitle.md)

#### Implements

IMessage<CUserMessageGameTitle\>, 
[IEquatable<CUserMessageGameTitle\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageGameTitle\>, 
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
[EnumerableExtensions.In<CUserMessageGameTitle\>\(CUserMessageGameTitle, params CUserMessageGameTitle\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageGameTitle__ctor"></a> CUserMessageGameTitle\(\)

```csharp
public CUserMessageGameTitle()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageGameTitle__ctor_Divine_Protobufs_Dota2_CUserMessageGameTitle_"></a> CUserMessageGameTitle\(CUserMessageGameTitle\)

```csharp
public CUserMessageGameTitle(CUserMessageGameTitle other)
```

#### Parameters

`other` [CUserMessageGameTitle](Divine.Protobufs.Dota2.CUserMessageGameTitle.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageGameTitle_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageGameTitle_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageGameTitle> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageGameTitle](Divine.Protobufs.Dota2.CUserMessageGameTitle.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageGameTitle_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageGameTitle_Clone"></a> Clone\(\)

```csharp
public CUserMessageGameTitle Clone()
```

#### Returns

 [CUserMessageGameTitle](Divine.Protobufs.Dota2.CUserMessageGameTitle.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageGameTitle_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageGameTitle_Equals_Divine_Protobufs_Dota2_CUserMessageGameTitle_"></a> Equals\(CUserMessageGameTitle\)

```csharp
public bool Equals(CUserMessageGameTitle other)
```

#### Parameters

`other` [CUserMessageGameTitle](Divine.Protobufs.Dota2.CUserMessageGameTitle.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageGameTitle_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageGameTitle_MergeFrom_Divine_Protobufs_Dota2_CUserMessageGameTitle_"></a> MergeFrom\(CUserMessageGameTitle\)

```csharp
public void MergeFrom(CUserMessageGameTitle other)
```

#### Parameters

`other` [CUserMessageGameTitle](Divine.Protobufs.Dota2.CUserMessageGameTitle.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageGameTitle_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageGameTitle_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageGameTitle_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

