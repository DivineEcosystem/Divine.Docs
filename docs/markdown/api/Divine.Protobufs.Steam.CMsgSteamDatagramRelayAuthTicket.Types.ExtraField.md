# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField"></a> Class CMsgSteamDatagramRelayAuthTicket.Types.ExtraField

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramRelayAuthTicket.Types.ExtraField : IMessage<CMsgSteamDatagramRelayAuthTicket.Types.ExtraField>, IEquatable<CMsgSteamDatagramRelayAuthTicket.Types.ExtraField>, IDeepCloneable<CMsgSteamDatagramRelayAuthTicket.Types.ExtraField>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramRelayAuthTicket.Types.ExtraField](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.Types.ExtraField.md)

#### Implements

IMessage<CMsgSteamDatagramRelayAuthTicket.Types.ExtraField\>, 
[IEquatable<CMsgSteamDatagramRelayAuthTicket.Types.ExtraField\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramRelayAuthTicket.Types.ExtraField\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramRelayAuthTicket.Types.ExtraField\>\(CMsgSteamDatagramRelayAuthTicket.Types.ExtraField, params CMsgSteamDatagramRelayAuthTicket.Types.ExtraField\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField__ctor"></a> ExtraField\(\)

```csharp
public ExtraField()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_"></a> ExtraField\(ExtraField\)

```csharp
public ExtraField(CMsgSteamDatagramRelayAuthTicket.Types.ExtraField other)
```

#### Parameters

`other` [CMsgSteamDatagramRelayAuthTicket](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.Types.md).[ExtraField](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.Types.ExtraField.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_Fixed64ValueFieldNumber"></a> Fixed64ValueFieldNumber

```csharp
public const int Fixed64ValueFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_Int64ValueFieldNumber"></a> Int64ValueFieldNumber

```csharp
public const int Int64ValueFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_StringValueFieldNumber"></a> StringValueFieldNumber

```csharp
public const int StringValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_Fixed64Value"></a> Fixed64Value

```csharp
public ulong Fixed64Value { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_HasFixed64Value"></a> HasFixed64Value

```csharp
public bool HasFixed64Value { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_HasInt64Value"></a> HasInt64Value

```csharp
public bool HasInt64Value { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_HasStringValue"></a> HasStringValue

```csharp
public bool HasStringValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_Int64Value"></a> Int64Value

```csharp
public long Int64Value { get; set; }
```

#### Property Value

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramRelayAuthTicket.Types.ExtraField> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramRelayAuthTicket](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.Types.md).[ExtraField](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.Types.ExtraField.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_StringValue"></a> StringValue

```csharp
public string StringValue { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_ClearFixed64Value"></a> ClearFixed64Value\(\)

```csharp
public void ClearFixed64Value()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_ClearInt64Value"></a> ClearInt64Value\(\)

```csharp
public void ClearInt64Value()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_ClearStringValue"></a> ClearStringValue\(\)

```csharp
public void ClearStringValue()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramRelayAuthTicket.Types.ExtraField Clone()
```

#### Returns

 [CMsgSteamDatagramRelayAuthTicket](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.Types.md).[ExtraField](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.Types.ExtraField.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_"></a> Equals\(ExtraField\)

```csharp
public bool Equals(CMsgSteamDatagramRelayAuthTicket.Types.ExtraField other)
```

#### Parameters

`other` [CMsgSteamDatagramRelayAuthTicket](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.Types.md).[ExtraField](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.Types.ExtraField.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_"></a> MergeFrom\(ExtraField\)

```csharp
public void MergeFrom(CMsgSteamDatagramRelayAuthTicket.Types.ExtraField other)
```

#### Parameters

`other` [CMsgSteamDatagramRelayAuthTicket](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.Types.md).[ExtraField](Divine.Protobufs.Steam.CMsgSteamDatagramRelayAuthTicket.Types.ExtraField.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramRelayAuthTicket_Types_ExtraField_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

