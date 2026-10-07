# <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response"></a> Class CMsgGCCheckClanMembership\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCCheckClanMembership_Response : IMessage<CMsgGCCheckClanMembership_Response>, IEquatable<CMsgGCCheckClanMembership_Response>, IDeepCloneable<CMsgGCCheckClanMembership_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCCheckClanMembership\_Response](Divine.Protobufs.Steam.CMsgGCCheckClanMembership\_Response.md)

#### Implements

IMessage<CMsgGCCheckClanMembership\_Response\>, 
[IEquatable<CMsgGCCheckClanMembership\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCCheckClanMembership\_Response\>, 
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
[EnumerableExtensions.In<CMsgGCCheckClanMembership\_Response\>\(CMsgGCCheckClanMembership\_Response, params CMsgGCCheckClanMembership\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response__ctor"></a> CMsgGCCheckClanMembership\_Response\(\)

```csharp
public CMsgGCCheckClanMembership_Response()
```

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response__ctor_Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response_"></a> CMsgGCCheckClanMembership\_Response\(CMsgGCCheckClanMembership\_Response\)

```csharp
public CMsgGCCheckClanMembership_Response(CMsgGCCheckClanMembership_Response other)
```

#### Parameters

`other` [CMsgGCCheckClanMembership\_Response](Divine.Protobufs.Steam.CMsgGCCheckClanMembership\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response_IsmemberFieldNumber"></a> IsmemberFieldNumber

```csharp
public const int IsmemberFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response_HasIsmember"></a> HasIsmember

```csharp
public bool HasIsmember { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response_Ismember"></a> Ismember

```csharp
public bool Ismember { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCCheckClanMembership_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCCheckClanMembership\_Response](Divine.Protobufs.Steam.CMsgGCCheckClanMembership\_Response.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response_ClearIsmember"></a> ClearIsmember\(\)

```csharp
public void ClearIsmember()
```

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response_Clone"></a> Clone\(\)

```csharp
public CMsgGCCheckClanMembership_Response Clone()
```

#### Returns

 [CMsgGCCheckClanMembership\_Response](Divine.Protobufs.Steam.CMsgGCCheckClanMembership\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response_Equals_Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response_"></a> Equals\(CMsgGCCheckClanMembership\_Response\)

```csharp
public bool Equals(CMsgGCCheckClanMembership_Response other)
```

#### Parameters

`other` [CMsgGCCheckClanMembership\_Response](Divine.Protobufs.Steam.CMsgGCCheckClanMembership\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response_MergeFrom_Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response_"></a> MergeFrom\(CMsgGCCheckClanMembership\_Response\)

```csharp
public void MergeFrom(CMsgGCCheckClanMembership_Response other)
```

#### Parameters

`other` [CMsgGCCheckClanMembership\_Response](Divine.Protobufs.Steam.CMsgGCCheckClanMembership\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

