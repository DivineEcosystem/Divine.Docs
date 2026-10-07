# <a id="Divine_Protobufs_Dota2_CCLCMsg_ServerStatus"></a> Class CCLCMsg\_ServerStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CCLCMsg_ServerStatus : IMessage<CCLCMsg_ServerStatus>, IEquatable<CCLCMsg_ServerStatus>, IDeepCloneable<CCLCMsg_ServerStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CCLCMsg\_ServerStatus](Divine.Protobufs.Dota2.CCLCMsg\_ServerStatus.md)

#### Implements

IMessage<CCLCMsg\_ServerStatus\>, 
[IEquatable<CCLCMsg\_ServerStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CCLCMsg\_ServerStatus\>, 
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
[EnumerableExtensions.In<CCLCMsg\_ServerStatus\>\(CCLCMsg\_ServerStatus, params CCLCMsg\_ServerStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ServerStatus__ctor"></a> CCLCMsg\_ServerStatus\(\)

```csharp
public CCLCMsg_ServerStatus()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ServerStatus__ctor_Divine_Protobufs_Dota2_CCLCMsg_ServerStatus_"></a> CCLCMsg\_ServerStatus\(CCLCMsg\_ServerStatus\)

```csharp
public CCLCMsg_ServerStatus(CCLCMsg_ServerStatus other)
```

#### Parameters

`other` [CCLCMsg\_ServerStatus](Divine.Protobufs.Dota2.CCLCMsg\_ServerStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ServerStatus_SimplifiedFieldNumber"></a> SimplifiedFieldNumber

```csharp
public const int SimplifiedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ServerStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ServerStatus_HasSimplified"></a> HasSimplified

```csharp
public bool HasSimplified { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ServerStatus_Parser"></a> Parser

```csharp
public static MessageParser<CCLCMsg_ServerStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CCLCMsg\_ServerStatus](Divine.Protobufs.Dota2.CCLCMsg\_ServerStatus.md)\>

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ServerStatus_Simplified"></a> Simplified

```csharp
public bool Simplified { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ServerStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ServerStatus_ClearSimplified"></a> ClearSimplified\(\)

```csharp
public void ClearSimplified()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ServerStatus_Clone"></a> Clone\(\)

```csharp
public CCLCMsg_ServerStatus Clone()
```

#### Returns

 [CCLCMsg\_ServerStatus](Divine.Protobufs.Dota2.CCLCMsg\_ServerStatus.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ServerStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ServerStatus_Equals_Divine_Protobufs_Dota2_CCLCMsg_ServerStatus_"></a> Equals\(CCLCMsg\_ServerStatus\)

```csharp
public bool Equals(CCLCMsg_ServerStatus other)
```

#### Parameters

`other` [CCLCMsg\_ServerStatus](Divine.Protobufs.Dota2.CCLCMsg\_ServerStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ServerStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ServerStatus_MergeFrom_Divine_Protobufs_Dota2_CCLCMsg_ServerStatus_"></a> MergeFrom\(CCLCMsg\_ServerStatus\)

```csharp
public void MergeFrom(CCLCMsg_ServerStatus other)
```

#### Parameters

`other` [CCLCMsg\_ServerStatus](Divine.Protobufs.Dota2.CCLCMsg\_ServerStatus.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ServerStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ServerStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ServerStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

