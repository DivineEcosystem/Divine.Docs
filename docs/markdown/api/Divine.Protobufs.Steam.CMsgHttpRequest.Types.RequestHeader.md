# <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader"></a> Class CMsgHttpRequest.Types.RequestHeader

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgHttpRequest.Types.RequestHeader : IMessage<CMsgHttpRequest.Types.RequestHeader>, IEquatable<CMsgHttpRequest.Types.RequestHeader>, IDeepCloneable<CMsgHttpRequest.Types.RequestHeader>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgHttpRequest.Types.RequestHeader](Divine.Protobufs.Steam.CMsgHttpRequest.Types.RequestHeader.md)

#### Implements

IMessage<CMsgHttpRequest.Types.RequestHeader\>, 
[IEquatable<CMsgHttpRequest.Types.RequestHeader\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgHttpRequest.Types.RequestHeader\>, 
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
[EnumerableExtensions.In<CMsgHttpRequest.Types.RequestHeader\>\(CMsgHttpRequest.Types.RequestHeader, params CMsgHttpRequest.Types.RequestHeader\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader__ctor"></a> RequestHeader\(\)

```csharp
public RequestHeader()
```

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader__ctor_Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_"></a> RequestHeader\(RequestHeader\)

```csharp
public RequestHeader(CMsgHttpRequest.Types.RequestHeader other)
```

#### Parameters

`other` [CMsgHttpRequest](Divine.Protobufs.Steam.CMsgHttpRequest.md).[Types](Divine.Protobufs.Steam.CMsgHttpRequest.Types.md).[RequestHeader](Divine.Protobufs.Steam.CMsgHttpRequest.Types.RequestHeader.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_Parser"></a> Parser

```csharp
public static MessageParser<CMsgHttpRequest.Types.RequestHeader> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgHttpRequest](Divine.Protobufs.Steam.CMsgHttpRequest.md).[Types](Divine.Protobufs.Steam.CMsgHttpRequest.Types.md).[RequestHeader](Divine.Protobufs.Steam.CMsgHttpRequest.Types.RequestHeader.md)\>

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_Value"></a> Value

```csharp
public string Value { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_Clone"></a> Clone\(\)

```csharp
public CMsgHttpRequest.Types.RequestHeader Clone()
```

#### Returns

 [CMsgHttpRequest](Divine.Protobufs.Steam.CMsgHttpRequest.md).[Types](Divine.Protobufs.Steam.CMsgHttpRequest.Types.md).[RequestHeader](Divine.Protobufs.Steam.CMsgHttpRequest.Types.RequestHeader.md)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_Equals_Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_"></a> Equals\(RequestHeader\)

```csharp
public bool Equals(CMsgHttpRequest.Types.RequestHeader other)
```

#### Parameters

`other` [CMsgHttpRequest](Divine.Protobufs.Steam.CMsgHttpRequest.md).[Types](Divine.Protobufs.Steam.CMsgHttpRequest.Types.md).[RequestHeader](Divine.Protobufs.Steam.CMsgHttpRequest.Types.RequestHeader.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_MergeFrom_Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_"></a> MergeFrom\(RequestHeader\)

```csharp
public void MergeFrom(CMsgHttpRequest.Types.RequestHeader other)
```

#### Parameters

`other` [CMsgHttpRequest](Divine.Protobufs.Steam.CMsgHttpRequest.md).[Types](Divine.Protobufs.Steam.CMsgHttpRequest.Types.md).[RequestHeader](Divine.Protobufs.Steam.CMsgHttpRequest.Types.RequestHeader.md)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Types_RequestHeader_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

