# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping"></a> Class CDOTAUserMsg\_Ping

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_Ping : IMessage<CDOTAUserMsg_Ping>, IEquatable<CDOTAUserMsg_Ping>, IDeepCloneable<CDOTAUserMsg_Ping>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_Ping](Divine.Protobufs.Dota2.CDOTAUserMsg\_Ping.md)

#### Implements

IMessage<CDOTAUserMsg\_Ping\>, 
[IEquatable<CDOTAUserMsg\_Ping\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_Ping\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_Ping\>\(CDOTAUserMsg\_Ping, params CDOTAUserMsg\_Ping\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping__ctor"></a> CDOTAUserMsg\_Ping\(\)

```csharp
public CDOTAUserMsg_Ping()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_"></a> CDOTAUserMsg\_Ping\(CDOTAUserMsg\_Ping\)

```csharp
public CDOTAUserMsg_Ping(CDOTAUserMsg_Ping other)
```

#### Parameters

`other` [CDOTAUserMsg\_Ping](Divine.Protobufs.Dota2.CDOTAUserMsg\_Ping.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_LossFieldNumber"></a> LossFieldNumber

```csharp
public const int LossFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_PingFieldNumber"></a> PingFieldNumber

```csharp
public const int PingFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_HasLoss"></a> HasLoss

```csharp
public bool HasLoss { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_HasPing"></a> HasPing

```csharp
public bool HasPing { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_Loss"></a> Loss

```csharp
public uint Loss { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_Ping> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_Ping](Divine.Protobufs.Dota2.CDOTAUserMsg\_Ping.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_Ping"></a> Ping

```csharp
public uint Ping { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_ClearLoss"></a> ClearLoss\(\)

```csharp
public void ClearLoss()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_ClearPing"></a> ClearPing\(\)

```csharp
public void ClearPing()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_Ping Clone()
```

#### Returns

 [CDOTAUserMsg\_Ping](Divine.Protobufs.Dota2.CDOTAUserMsg\_Ping.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_"></a> Equals\(CDOTAUserMsg\_Ping\)

```csharp
public bool Equals(CDOTAUserMsg_Ping other)
```

#### Parameters

`other` [CDOTAUserMsg\_Ping](Divine.Protobufs.Dota2.CDOTAUserMsg\_Ping.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_"></a> MergeFrom\(CDOTAUserMsg\_Ping\)

```csharp
public void MergeFrom(CDOTAUserMsg_Ping other)
```

#### Parameters

`other` [CDOTAUserMsg\_Ping](Divine.Protobufs.Dota2.CDOTAUserMsg\_Ping.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_Ping_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

