# <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response"></a> Class CMsgGCGetPersonaNames\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCGetPersonaNames_Response : IMessage<CMsgGCGetPersonaNames_Response>, IEquatable<CMsgGCGetPersonaNames_Response>, IDeepCloneable<CMsgGCGetPersonaNames_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCGetPersonaNames\_Response](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.md)

#### Implements

IMessage<CMsgGCGetPersonaNames\_Response\>, 
[IEquatable<CMsgGCGetPersonaNames\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCGetPersonaNames\_Response\>, 
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
[EnumerableExtensions.In<CMsgGCGetPersonaNames\_Response\>\(CMsgGCGetPersonaNames\_Response, params CMsgGCGetPersonaNames\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response__ctor"></a> CMsgGCGetPersonaNames\_Response\(\)

```csharp
public CMsgGCGetPersonaNames_Response()
```

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response__ctor_Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_"></a> CMsgGCGetPersonaNames\_Response\(CMsgGCGetPersonaNames\_Response\)

```csharp
public CMsgGCGetPersonaNames_Response(CMsgGCGetPersonaNames_Response other)
```

#### Parameters

`other` [CMsgGCGetPersonaNames\_Response](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_FailedLookupSteamidsFieldNumber"></a> FailedLookupSteamidsFieldNumber

```csharp
public const int FailedLookupSteamidsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_SucceededLookupsFieldNumber"></a> SucceededLookupsFieldNumber

```csharp
public const int SucceededLookupsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_FailedLookupSteamids"></a> FailedLookupSteamids

```csharp
public RepeatedField<ulong> FailedLookupSteamids { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCGetPersonaNames_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCGetPersonaNames\_Response](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_SucceededLookups"></a> SucceededLookups

```csharp
public RepeatedField<CMsgGCGetPersonaNames_Response.Types.PersonaName> SucceededLookups { get; }
```

#### Property Value

 RepeatedField<[CMsgGCGetPersonaNames\_Response](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.md).[Types](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.Types.md).[PersonaName](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.Types.PersonaName.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Clone"></a> Clone\(\)

```csharp
public CMsgGCGetPersonaNames_Response Clone()
```

#### Returns

 [CMsgGCGetPersonaNames\_Response](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Equals_Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_"></a> Equals\(CMsgGCGetPersonaNames\_Response\)

```csharp
public bool Equals(CMsgGCGetPersonaNames_Response other)
```

#### Parameters

`other` [CMsgGCGetPersonaNames\_Response](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_MergeFrom_Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_"></a> MergeFrom\(CMsgGCGetPersonaNames\_Response\)

```csharp
public void MergeFrom(CMsgGCGetPersonaNames_Response other)
```

#### Parameters

`other` [CMsgGCGetPersonaNames\_Response](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

