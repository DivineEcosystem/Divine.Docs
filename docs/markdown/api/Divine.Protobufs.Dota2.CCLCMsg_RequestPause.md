# <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause"></a> Class CCLCMsg\_RequestPause

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CCLCMsg_RequestPause : IMessage<CCLCMsg_RequestPause>, IEquatable<CCLCMsg_RequestPause>, IDeepCloneable<CCLCMsg_RequestPause>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CCLCMsg\_RequestPause](Divine.Protobufs.Dota2.CCLCMsg\_RequestPause.md)

#### Implements

IMessage<CCLCMsg\_RequestPause\>, 
[IEquatable<CCLCMsg\_RequestPause\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CCLCMsg\_RequestPause\>, 
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
[EnumerableExtensions.In<CCLCMsg\_RequestPause\>\(CCLCMsg\_RequestPause, params CCLCMsg\_RequestPause\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause__ctor"></a> CCLCMsg\_RequestPause\(\)

```csharp
public CCLCMsg_RequestPause()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause__ctor_Divine_Protobufs_Dota2_CCLCMsg_RequestPause_"></a> CCLCMsg\_RequestPause\(CCLCMsg\_RequestPause\)

```csharp
public CCLCMsg_RequestPause(CCLCMsg_RequestPause other)
```

#### Parameters

`other` [CCLCMsg\_RequestPause](Divine.Protobufs.Dota2.CCLCMsg\_RequestPause.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause_PauseGroupFieldNumber"></a> PauseGroupFieldNumber

```csharp
public const int PauseGroupFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause_PauseTypeFieldNumber"></a> PauseTypeFieldNumber

```csharp
public const int PauseTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause_HasPauseGroup"></a> HasPauseGroup

```csharp
public bool HasPauseGroup { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause_HasPauseType"></a> HasPauseType

```csharp
public bool HasPauseType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause_Parser"></a> Parser

```csharp
public static MessageParser<CCLCMsg_RequestPause> Parser { get; }
```

#### Property Value

 MessageParser<[CCLCMsg\_RequestPause](Divine.Protobufs.Dota2.CCLCMsg\_RequestPause.md)\>

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause_PauseGroup"></a> PauseGroup

```csharp
public int PauseGroup { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause_PauseType"></a> PauseType

```csharp
public RequestPause_t PauseType { get; set; }
```

#### Property Value

 [RequestPause\_t](Divine.Protobufs.Dota2.RequestPause\_t.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause_ClearPauseGroup"></a> ClearPauseGroup\(\)

```csharp
public void ClearPauseGroup()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause_ClearPauseType"></a> ClearPauseType\(\)

```csharp
public void ClearPauseType()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause_Clone"></a> Clone\(\)

```csharp
public CCLCMsg_RequestPause Clone()
```

#### Returns

 [CCLCMsg\_RequestPause](Divine.Protobufs.Dota2.CCLCMsg\_RequestPause.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause_Equals_Divine_Protobufs_Dota2_CCLCMsg_RequestPause_"></a> Equals\(CCLCMsg\_RequestPause\)

```csharp
public bool Equals(CCLCMsg_RequestPause other)
```

#### Parameters

`other` [CCLCMsg\_RequestPause](Divine.Protobufs.Dota2.CCLCMsg\_RequestPause.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause_MergeFrom_Divine_Protobufs_Dota2_CCLCMsg_RequestPause_"></a> MergeFrom\(CCLCMsg\_RequestPause\)

```csharp
public void MergeFrom(CCLCMsg_RequestPause other)
```

#### Parameters

`other` [CCLCMsg\_RequestPause](Divine.Protobufs.Dota2.CCLCMsg\_RequestPause.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_RequestPause_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

