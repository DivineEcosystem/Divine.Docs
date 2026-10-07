# <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary"></a> Class CMsgSignOutCommunicationSummary

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutCommunicationSummary : IMessage<CMsgSignOutCommunicationSummary>, IEquatable<CMsgSignOutCommunicationSummary>, IDeepCloneable<CMsgSignOutCommunicationSummary>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutCommunicationSummary](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.md)

#### Implements

IMessage<CMsgSignOutCommunicationSummary\>, 
[IEquatable<CMsgSignOutCommunicationSummary\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutCommunicationSummary\>, 
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
[EnumerableExtensions.In<CMsgSignOutCommunicationSummary\>\(CMsgSignOutCommunicationSummary, params CMsgSignOutCommunicationSummary\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary__ctor"></a> CMsgSignOutCommunicationSummary\(\)

```csharp
public CMsgSignOutCommunicationSummary()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary__ctor_Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_"></a> CMsgSignOutCommunicationSummary\(CMsgSignOutCommunicationSummary\)

```csharp
public CMsgSignOutCommunicationSummary(CMsgSignOutCommunicationSummary other)
```

#### Parameters

`other` [CMsgSignOutCommunicationSummary](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutCommunicationSummary> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutCommunicationSummary](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Players"></a> Players

```csharp
public RepeatedField<CMsgSignOutCommunicationSummary.Types.PlayerCommunication> Players { get; }
```

#### Property Value

 RepeatedField<[CMsgSignOutCommunicationSummary](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.md).[PlayerCommunication](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.PlayerCommunication.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutCommunicationSummary Clone()
```

#### Returns

 [CMsgSignOutCommunicationSummary](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Equals_Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_"></a> Equals\(CMsgSignOutCommunicationSummary\)

```csharp
public bool Equals(CMsgSignOutCommunicationSummary other)
```

#### Parameters

`other` [CMsgSignOutCommunicationSummary](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_"></a> MergeFrom\(CMsgSignOutCommunicationSummary\)

```csharp
public void MergeFrom(CMsgSignOutCommunicationSummary other)
```

#### Parameters

`other` [CMsgSignOutCommunicationSummary](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

