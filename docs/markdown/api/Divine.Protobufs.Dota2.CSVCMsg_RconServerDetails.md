# <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails"></a> Class CSVCMsg\_RconServerDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_RconServerDetails : IMessage<CSVCMsg_RconServerDetails>, IEquatable<CSVCMsg_RconServerDetails>, IDeepCloneable<CSVCMsg_RconServerDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_RconServerDetails](Divine.Protobufs.Dota2.CSVCMsg\_RconServerDetails.md)

#### Implements

IMessage<CSVCMsg\_RconServerDetails\>, 
[IEquatable<CSVCMsg\_RconServerDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_RconServerDetails\>, 
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
[EnumerableExtensions.In<CSVCMsg\_RconServerDetails\>\(CSVCMsg\_RconServerDetails, params CSVCMsg\_RconServerDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails__ctor"></a> CSVCMsg\_RconServerDetails\(\)

```csharp
public CSVCMsg_RconServerDetails()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails__ctor_Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_"></a> CSVCMsg\_RconServerDetails\(CSVCMsg\_RconServerDetails\)

```csharp
public CSVCMsg_RconServerDetails(CSVCMsg_RconServerDetails other)
```

#### Parameters

`other` [CSVCMsg\_RconServerDetails](Divine.Protobufs.Dota2.CSVCMsg\_RconServerDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_DetailsFieldNumber"></a> DetailsFieldNumber

```csharp
public const int DetailsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_TokenFieldNumber"></a> TokenFieldNumber

```csharp
public const int TokenFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_Details"></a> Details

```csharp
public string Details { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_HasDetails"></a> HasDetails

```csharp
public bool HasDetails { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_HasToken"></a> HasToken

```csharp
public bool HasToken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_RconServerDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_RconServerDetails](Divine.Protobufs.Dota2.CSVCMsg\_RconServerDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_Token"></a> Token

```csharp
public ByteString Token { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_ClearDetails"></a> ClearDetails\(\)

```csharp
public void ClearDetails()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_ClearToken"></a> ClearToken\(\)

```csharp
public void ClearToken()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_RconServerDetails Clone()
```

#### Returns

 [CSVCMsg\_RconServerDetails](Divine.Protobufs.Dota2.CSVCMsg\_RconServerDetails.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_Equals_Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_"></a> Equals\(CSVCMsg\_RconServerDetails\)

```csharp
public bool Equals(CSVCMsg_RconServerDetails other)
```

#### Parameters

`other` [CSVCMsg\_RconServerDetails](Divine.Protobufs.Dota2.CSVCMsg\_RconServerDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_"></a> MergeFrom\(CSVCMsg\_RconServerDetails\)

```csharp
public void MergeFrom(CSVCMsg_RconServerDetails other)
```

#### Parameters

`other` [CSVCMsg\_RconServerDetails](Divine.Protobufs.Dota2.CSVCMsg\_RconServerDetails.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_RconServerDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

