# <a id="Divine_Protobufs_Dota2_CUserMessageSayText2"></a> Class CUserMessageSayText2

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageSayText2 : IMessage<CUserMessageSayText2>, IEquatable<CUserMessageSayText2>, IDeepCloneable<CUserMessageSayText2>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageSayText2](Divine.Protobufs.Dota2.CUserMessageSayText2.md)

#### Implements

IMessage<CUserMessageSayText2\>, 
[IEquatable<CUserMessageSayText2\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageSayText2\>, 
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
[EnumerableExtensions.In<CUserMessageSayText2\>\(CUserMessageSayText2, params CUserMessageSayText2\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2__ctor"></a> CUserMessageSayText2\(\)

```csharp
public CUserMessageSayText2()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2__ctor_Divine_Protobufs_Dota2_CUserMessageSayText2_"></a> CUserMessageSayText2\(CUserMessageSayText2\)

```csharp
public CUserMessageSayText2(CUserMessageSayText2 other)
```

#### Parameters

`other` [CUserMessageSayText2](Divine.Protobufs.Dota2.CUserMessageSayText2.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_ChatFieldNumber"></a> ChatFieldNumber

```csharp
public const int ChatFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_EntityindexFieldNumber"></a> EntityindexFieldNumber

```csharp
public const int EntityindexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_MessagenameFieldNumber"></a> MessagenameFieldNumber

```csharp
public const int MessagenameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_Param1FieldNumber"></a> Param1FieldNumber

```csharp
public const int Param1FieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_Param2FieldNumber"></a> Param2FieldNumber

```csharp
public const int Param2FieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_Param3FieldNumber"></a> Param3FieldNumber

```csharp
public const int Param3FieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_Param4FieldNumber"></a> Param4FieldNumber

```csharp
public const int Param4FieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_TextallchatFieldNumber"></a> TextallchatFieldNumber

```csharp
public const int TextallchatFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_Chat"></a> Chat

```csharp
public bool Chat { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_Entityindex"></a> Entityindex

```csharp
public int Entityindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_HasChat"></a> HasChat

```csharp
public bool HasChat { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_HasEntityindex"></a> HasEntityindex

```csharp
public bool HasEntityindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_HasMessagename"></a> HasMessagename

```csharp
public bool HasMessagename { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_HasParam1"></a> HasParam1

```csharp
public bool HasParam1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_HasParam2"></a> HasParam2

```csharp
public bool HasParam2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_HasParam3"></a> HasParam3

```csharp
public bool HasParam3 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_HasParam4"></a> HasParam4

```csharp
public bool HasParam4 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_HasTextallchat"></a> HasTextallchat

```csharp
public bool HasTextallchat { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_Messagename"></a> Messagename

```csharp
public string Messagename { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_Param1"></a> Param1

```csharp
public string Param1 { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_Param2"></a> Param2

```csharp
public string Param2 { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_Param3"></a> Param3

```csharp
public string Param3 { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_Param4"></a> Param4

```csharp
public string Param4 { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageSayText2> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageSayText2](Divine.Protobufs.Dota2.CUserMessageSayText2.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_Textallchat"></a> Textallchat

```csharp
public bool Textallchat { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_ClearChat"></a> ClearChat\(\)

```csharp
public void ClearChat()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_ClearEntityindex"></a> ClearEntityindex\(\)

```csharp
public void ClearEntityindex()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_ClearMessagename"></a> ClearMessagename\(\)

```csharp
public void ClearMessagename()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_ClearParam1"></a> ClearParam1\(\)

```csharp
public void ClearParam1()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_ClearParam2"></a> ClearParam2\(\)

```csharp
public void ClearParam2()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_ClearParam3"></a> ClearParam3\(\)

```csharp
public void ClearParam3()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_ClearParam4"></a> ClearParam4\(\)

```csharp
public void ClearParam4()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_ClearTextallchat"></a> ClearTextallchat\(\)

```csharp
public void ClearTextallchat()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_Clone"></a> Clone\(\)

```csharp
public CUserMessageSayText2 Clone()
```

#### Returns

 [CUserMessageSayText2](Divine.Protobufs.Dota2.CUserMessageSayText2.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_Equals_Divine_Protobufs_Dota2_CUserMessageSayText2_"></a> Equals\(CUserMessageSayText2\)

```csharp
public bool Equals(CUserMessageSayText2 other)
```

#### Parameters

`other` [CUserMessageSayText2](Divine.Protobufs.Dota2.CUserMessageSayText2.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_MergeFrom_Divine_Protobufs_Dota2_CUserMessageSayText2_"></a> MergeFrom\(CUserMessageSayText2\)

```csharp
public void MergeFrom(CUserMessageSayText2 other)
```

#### Parameters

`other` [CUserMessageSayText2](Divine.Protobufs.Dota2.CUserMessageSayText2.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageSayText2_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

