# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth"></a> Class CDOTAUserMsg\_ShovelUnearth

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_ShovelUnearth : IMessage<CDOTAUserMsg_ShovelUnearth>, IEquatable<CDOTAUserMsg_ShovelUnearth>, IDeepCloneable<CDOTAUserMsg_ShovelUnearth>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_ShovelUnearth](Divine.Protobufs.Dota2.CDOTAUserMsg\_ShovelUnearth.md)

#### Implements

IMessage<CDOTAUserMsg\_ShovelUnearth\>, 
[IEquatable<CDOTAUserMsg\_ShovelUnearth\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_ShovelUnearth\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_ShovelUnearth\>\(CDOTAUserMsg\_ShovelUnearth, params CDOTAUserMsg\_ShovelUnearth\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth__ctor"></a> CDOTAUserMsg\_ShovelUnearth\(\)

```csharp
public CDOTAUserMsg_ShovelUnearth()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_"></a> CDOTAUserMsg\_ShovelUnearth\(CDOTAUserMsg\_ShovelUnearth\)

```csharp
public CDOTAUserMsg_ShovelUnearth(CDOTAUserMsg_ShovelUnearth other)
```

#### Parameters

`other` [CDOTAUserMsg\_ShovelUnearth](Divine.Protobufs.Dota2.CDOTAUserMsg\_ShovelUnearth.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_AllChatFieldNumber"></a> AllChatFieldNumber

```csharp
public const int AllChatFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_LocstringFieldNumber"></a> LocstringFieldNumber

```csharp
public const int LocstringFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_QuantityFieldNumber"></a> QuantityFieldNumber

```csharp
public const int QuantityFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_AllChat"></a> AllChat

```csharp
public bool AllChat { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_HasAllChat"></a> HasAllChat

```csharp
public bool HasAllChat { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_HasLocstring"></a> HasLocstring

```csharp
public bool HasLocstring { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_HasQuantity"></a> HasQuantity

```csharp
public bool HasQuantity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_Locstring"></a> Locstring

```csharp
public string Locstring { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_ShovelUnearth> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_ShovelUnearth](Divine.Protobufs.Dota2.CDOTAUserMsg\_ShovelUnearth.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_Quantity"></a> Quantity

```csharp
public uint Quantity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_ClearAllChat"></a> ClearAllChat\(\)

```csharp
public void ClearAllChat()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_ClearLocstring"></a> ClearLocstring\(\)

```csharp
public void ClearLocstring()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_ClearQuantity"></a> ClearQuantity\(\)

```csharp
public void ClearQuantity()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_ShovelUnearth Clone()
```

#### Returns

 [CDOTAUserMsg\_ShovelUnearth](Divine.Protobufs.Dota2.CDOTAUserMsg\_ShovelUnearth.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_"></a> Equals\(CDOTAUserMsg\_ShovelUnearth\)

```csharp
public bool Equals(CDOTAUserMsg_ShovelUnearth other)
```

#### Parameters

`other` [CDOTAUserMsg\_ShovelUnearth](Divine.Protobufs.Dota2.CDOTAUserMsg\_ShovelUnearth.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_"></a> MergeFrom\(CDOTAUserMsg\_ShovelUnearth\)

```csharp
public void MergeFrom(CDOTAUserMsg_ShovelUnearth other)
```

#### Parameters

`other` [CDOTAUserMsg\_ShovelUnearth](Divine.Protobufs.Dota2.CDOTAUserMsg\_ShovelUnearth.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShovelUnearth_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

