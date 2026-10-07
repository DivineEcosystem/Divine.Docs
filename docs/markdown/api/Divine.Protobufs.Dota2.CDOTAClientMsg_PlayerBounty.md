# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty"></a> Class CDOTAClientMsg\_PlayerBounty

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_PlayerBounty : IMessage<CDOTAClientMsg_PlayerBounty>, IEquatable<CDOTAClientMsg_PlayerBounty>, IDeepCloneable<CDOTAClientMsg_PlayerBounty>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_PlayerBounty](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerBounty.md)

#### Implements

IMessage<CDOTAClientMsg\_PlayerBounty\>, 
[IEquatable<CDOTAClientMsg\_PlayerBounty\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_PlayerBounty\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_PlayerBounty\>\(CDOTAClientMsg\_PlayerBounty, params CDOTAClientMsg\_PlayerBounty\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty__ctor"></a> CDOTAClientMsg\_PlayerBounty\(\)

```csharp
public CDOTAClientMsg_PlayerBounty()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty_"></a> CDOTAClientMsg\_PlayerBounty\(CDOTAClientMsg\_PlayerBounty\)

```csharp
public CDOTAClientMsg_PlayerBounty(CDOTAClientMsg_PlayerBounty other)
```

#### Parameters

`other` [CDOTAClientMsg\_PlayerBounty](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerBounty.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_PlayerBounty> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_PlayerBounty](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerBounty.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_PlayerBounty Clone()
```

#### Returns

 [CDOTAClientMsg\_PlayerBounty](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerBounty.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty_"></a> Equals\(CDOTAClientMsg\_PlayerBounty\)

```csharp
public bool Equals(CDOTAClientMsg_PlayerBounty other)
```

#### Parameters

`other` [CDOTAClientMsg\_PlayerBounty](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerBounty.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty_"></a> MergeFrom\(CDOTAClientMsg\_PlayerBounty\)

```csharp
public void MergeFrom(CDOTAClientMsg_PlayerBounty other)
```

#### Parameters

`other` [CDOTAClientMsg\_PlayerBounty](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerBounty.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerBounty_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

