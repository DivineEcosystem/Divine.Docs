# <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue"></a> Class CCLCMsg\_RespondCvarValue

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CCLCMsg_RespondCvarValue : IMessage<CCLCMsg_RespondCvarValue>, IEquatable<CCLCMsg_RespondCvarValue>, IDeepCloneable<CCLCMsg_RespondCvarValue>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CCLCMsg\_RespondCvarValue](Divine.Protobufs.Dota2.CCLCMsg\_RespondCvarValue.md)

#### Implements

IMessage<CCLCMsg\_RespondCvarValue\>, 
[IEquatable<CCLCMsg\_RespondCvarValue\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CCLCMsg\_RespondCvarValue\>, 
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
[EnumerableExtensions.In<CCLCMsg\_RespondCvarValue\>\(CCLCMsg\_RespondCvarValue, params CCLCMsg\_RespondCvarValue\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue__ctor"></a> CCLCMsg\_RespondCvarValue\(\)

```csharp
public CCLCMsg_RespondCvarValue()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue__ctor_Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_"></a> CCLCMsg\_RespondCvarValue\(CCLCMsg\_RespondCvarValue\)

```csharp
public CCLCMsg_RespondCvarValue(CCLCMsg_RespondCvarValue other)
```

#### Parameters

`other` [CCLCMsg\_RespondCvarValue](Divine.Protobufs.Dota2.CCLCMsg\_RespondCvarValue.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_CookieFieldNumber"></a> CookieFieldNumber

```csharp
public const int CookieFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_StatusCodeFieldNumber"></a> StatusCodeFieldNumber

```csharp
public const int StatusCodeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_Cookie"></a> Cookie

```csharp
public int Cookie { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_HasCookie"></a> HasCookie

```csharp
public bool HasCookie { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_HasStatusCode"></a> HasStatusCode

```csharp
public bool HasStatusCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_Parser"></a> Parser

```csharp
public static MessageParser<CCLCMsg_RespondCvarValue> Parser { get; }
```

#### Property Value

 MessageParser<[CCLCMsg\_RespondCvarValue](Divine.Protobufs.Dota2.CCLCMsg\_RespondCvarValue.md)\>

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_StatusCode"></a> StatusCode

```csharp
public int StatusCode { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_Value"></a> Value

```csharp
public string Value { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_ClearCookie"></a> ClearCookie\(\)

```csharp
public void ClearCookie()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_ClearStatusCode"></a> ClearStatusCode\(\)

```csharp
public void ClearStatusCode()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_Clone"></a> Clone\(\)

```csharp
public CCLCMsg_RespondCvarValue Clone()
```

#### Returns

 [CCLCMsg\_RespondCvarValue](Divine.Protobufs.Dota2.CCLCMsg\_RespondCvarValue.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_Equals_Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_"></a> Equals\(CCLCMsg\_RespondCvarValue\)

```csharp
public bool Equals(CCLCMsg_RespondCvarValue other)
```

#### Parameters

`other` [CCLCMsg\_RespondCvarValue](Divine.Protobufs.Dota2.CCLCMsg\_RespondCvarValue.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_MergeFrom_Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_"></a> MergeFrom\(CCLCMsg\_RespondCvarValue\)

```csharp
public void MergeFrom(CCLCMsg_RespondCvarValue other)
```

#### Parameters

`other` [CCLCMsg\_RespondCvarValue](Divine.Protobufs.Dota2.CCLCMsg\_RespondCvarValue.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RespondCvarValue_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

