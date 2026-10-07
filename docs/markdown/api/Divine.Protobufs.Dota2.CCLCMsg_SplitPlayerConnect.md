# <a id="Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect"></a> Class CCLCMsg\_SplitPlayerConnect

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CCLCMsg_SplitPlayerConnect : IMessage<CCLCMsg_SplitPlayerConnect>, IEquatable<CCLCMsg_SplitPlayerConnect>, IDeepCloneable<CCLCMsg_SplitPlayerConnect>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CCLCMsg\_SplitPlayerConnect](Divine.Protobufs.Dota2.CCLCMsg\_SplitPlayerConnect.md)

#### Implements

IMessage<CCLCMsg\_SplitPlayerConnect\>, 
[IEquatable<CCLCMsg\_SplitPlayerConnect\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CCLCMsg\_SplitPlayerConnect\>, 
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
[EnumerableExtensions.In<CCLCMsg\_SplitPlayerConnect\>\(CCLCMsg\_SplitPlayerConnect, params CCLCMsg\_SplitPlayerConnect\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect__ctor"></a> CCLCMsg\_SplitPlayerConnect\(\)

```csharp
public CCLCMsg_SplitPlayerConnect()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect__ctor_Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect_"></a> CCLCMsg\_SplitPlayerConnect\(CCLCMsg\_SplitPlayerConnect\)

```csharp
public CCLCMsg_SplitPlayerConnect(CCLCMsg_SplitPlayerConnect other)
```

#### Parameters

`other` [CCLCMsg\_SplitPlayerConnect](Divine.Protobufs.Dota2.CCLCMsg\_SplitPlayerConnect.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect_PlayernameFieldNumber"></a> PlayernameFieldNumber

```csharp
public const int PlayernameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect_HasPlayername"></a> HasPlayername

```csharp
public bool HasPlayername { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect_Parser"></a> Parser

```csharp
public static MessageParser<CCLCMsg_SplitPlayerConnect> Parser { get; }
```

#### Property Value

 MessageParser<[CCLCMsg\_SplitPlayerConnect](Divine.Protobufs.Dota2.CCLCMsg\_SplitPlayerConnect.md)\>

### <a id="Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect_Playername"></a> Playername

```csharp
public string Playername { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect_ClearPlayername"></a> ClearPlayername\(\)

```csharp
public void ClearPlayername()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect_Clone"></a> Clone\(\)

```csharp
public CCLCMsg_SplitPlayerConnect Clone()
```

#### Returns

 [CCLCMsg\_SplitPlayerConnect](Divine.Protobufs.Dota2.CCLCMsg\_SplitPlayerConnect.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect_Equals_Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect_"></a> Equals\(CCLCMsg\_SplitPlayerConnect\)

```csharp
public bool Equals(CCLCMsg_SplitPlayerConnect other)
```

#### Parameters

`other` [CCLCMsg\_SplitPlayerConnect](Divine.Protobufs.Dota2.CCLCMsg\_SplitPlayerConnect.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect_MergeFrom_Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect_"></a> MergeFrom\(CCLCMsg\_SplitPlayerConnect\)

```csharp
public void MergeFrom(CCLCMsg_SplitPlayerConnect other)
```

#### Parameters

`other` [CCLCMsg\_SplitPlayerConnect](Divine.Protobufs.Dota2.CCLCMsg\_SplitPlayerConnect.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_SplitPlayerConnect_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

