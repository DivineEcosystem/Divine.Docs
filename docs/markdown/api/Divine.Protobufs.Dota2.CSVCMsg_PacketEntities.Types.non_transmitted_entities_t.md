# <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t"></a> Class CSVCMsg\_PacketEntities.Types.non\_transmitted\_entities\_t

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_PacketEntities.Types.non_transmitted_entities_t : IMessage<CSVCMsg_PacketEntities.Types.non_transmitted_entities_t>, IEquatable<CSVCMsg_PacketEntities.Types.non_transmitted_entities_t>, IDeepCloneable<CSVCMsg_PacketEntities.Types.non_transmitted_entities_t>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_PacketEntities.Types.non\_transmitted\_entities\_t](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.non\_transmitted\_entities\_t.md)

#### Implements

IMessage<CSVCMsg\_PacketEntities.Types.non\_transmitted\_entities\_t\>, 
[IEquatable<CSVCMsg\_PacketEntities.Types.non\_transmitted\_entities\_t\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_PacketEntities.Types.non\_transmitted\_entities\_t\>, 
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
[EnumerableExtensions.In<CSVCMsg\_PacketEntities.Types.non\_transmitted\_entities\_t\>\(CSVCMsg\_PacketEntities.Types.non\_transmitted\_entities\_t, params CSVCMsg\_PacketEntities.Types.non\_transmitted\_entities\_t\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t__ctor"></a> non\_transmitted\_entities\_t\(\)

```csharp
public non_transmitted_entities_t()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t__ctor_Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_"></a> non\_transmitted\_entities\_t\(non\_transmitted\_entities\_t\)

```csharp
public non_transmitted_entities_t(CSVCMsg_PacketEntities.Types.non_transmitted_entities_t other)
```

#### Parameters

`other` [CSVCMsg\_PacketEntities](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.md).[non\_transmitted\_entities\_t](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.non\_transmitted\_entities\_t.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_HeaderCountFieldNumber"></a> HeaderCountFieldNumber

```csharp
public const int HeaderCountFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_Data"></a> Data

```csharp
public ByteString Data { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_HasHeaderCount"></a> HasHeaderCount

```csharp
public bool HasHeaderCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_HeaderCount"></a> HeaderCount

```csharp
public int HeaderCount { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_PacketEntities.Types.non_transmitted_entities_t> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_PacketEntities](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.md).[non\_transmitted\_entities\_t](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.non\_transmitted\_entities\_t.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_ClearHeaderCount"></a> ClearHeaderCount\(\)

```csharp
public void ClearHeaderCount()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_PacketEntities.Types.non_transmitted_entities_t Clone()
```

#### Returns

 [CSVCMsg\_PacketEntities](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.md).[non\_transmitted\_entities\_t](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.non\_transmitted\_entities\_t.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_Equals_Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_"></a> Equals\(non\_transmitted\_entities\_t\)

```csharp
public bool Equals(CSVCMsg_PacketEntities.Types.non_transmitted_entities_t other)
```

#### Parameters

`other` [CSVCMsg\_PacketEntities](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.md).[non\_transmitted\_entities\_t](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.non\_transmitted\_entities\_t.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_"></a> MergeFrom\(non\_transmitted\_entities\_t\)

```csharp
public void MergeFrom(CSVCMsg_PacketEntities.Types.non_transmitted_entities_t other)
```

#### Parameters

`other` [CSVCMsg\_PacketEntities](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.md).[non\_transmitted\_entities\_t](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.non\_transmitted\_entities\_t.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_non_transmitted_entities_t_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

