# <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName"></a> Class CMsgGCGetPersonaNames\_Response.Types.PersonaName

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCGetPersonaNames_Response.Types.PersonaName : IMessage<CMsgGCGetPersonaNames_Response.Types.PersonaName>, IEquatable<CMsgGCGetPersonaNames_Response.Types.PersonaName>, IDeepCloneable<CMsgGCGetPersonaNames_Response.Types.PersonaName>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCGetPersonaNames\_Response.Types.PersonaName](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.Types.PersonaName.md)

#### Implements

IMessage<CMsgGCGetPersonaNames\_Response.Types.PersonaName\>, 
[IEquatable<CMsgGCGetPersonaNames\_Response.Types.PersonaName\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCGetPersonaNames\_Response.Types.PersonaName\>, 
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
[EnumerableExtensions.In<CMsgGCGetPersonaNames\_Response.Types.PersonaName\>\(CMsgGCGetPersonaNames\_Response.Types.PersonaName, params CMsgGCGetPersonaNames\_Response.Types.PersonaName\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName__ctor"></a> PersonaName\(\)

```csharp
public PersonaName()
```

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName__ctor_Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_"></a> PersonaName\(PersonaName\)

```csharp
public PersonaName(CMsgGCGetPersonaNames_Response.Types.PersonaName other)
```

#### Parameters

`other` [CMsgGCGetPersonaNames\_Response](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.md).[Types](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.Types.md).[PersonaName](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.Types.PersonaName.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_PersonaName_FieldNumber"></a> PersonaName\_FieldNumber

```csharp
public const int PersonaName_FieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_HasPersonaName_"></a> HasPersonaName\_

```csharp
public bool HasPersonaName_ { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCGetPersonaNames_Response.Types.PersonaName> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCGetPersonaNames\_Response](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.md).[Types](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.Types.md).[PersonaName](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.Types.PersonaName.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_PersonaName_"></a> PersonaName\_

```csharp
public string PersonaName_ { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_ClearPersonaName_"></a> ClearPersonaName\_\(\)

```csharp
public void ClearPersonaName_()
```

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_Clone"></a> Clone\(\)

```csharp
public CMsgGCGetPersonaNames_Response.Types.PersonaName Clone()
```

#### Returns

 [CMsgGCGetPersonaNames\_Response](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.md).[Types](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.Types.md).[PersonaName](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.Types.PersonaName.md)

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_Equals_Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_"></a> Equals\(PersonaName\)

```csharp
public bool Equals(CMsgGCGetPersonaNames_Response.Types.PersonaName other)
```

#### Parameters

`other` [CMsgGCGetPersonaNames\_Response](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.md).[Types](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.Types.md).[PersonaName](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.Types.PersonaName.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_MergeFrom_Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_"></a> MergeFrom\(PersonaName\)

```csharp
public void MergeFrom(CMsgGCGetPersonaNames_Response.Types.PersonaName other)
```

#### Parameters

`other` [CMsgGCGetPersonaNames\_Response](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.md).[Types](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.Types.md).[PersonaName](Divine.Protobufs.Steam.CMsgGCGetPersonaNames\_Response.Types.PersonaName.md)

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCGetPersonaNames_Response_Types_PersonaName_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

