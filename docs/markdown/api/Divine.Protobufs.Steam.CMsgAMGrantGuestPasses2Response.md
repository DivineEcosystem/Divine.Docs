# <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response"></a> Class CMsgAMGrantGuestPasses2Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAMGrantGuestPasses2Response : IMessage<CMsgAMGrantGuestPasses2Response>, IEquatable<CMsgAMGrantGuestPasses2Response>, IDeepCloneable<CMsgAMGrantGuestPasses2Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAMGrantGuestPasses2Response](Divine.Protobufs.Steam.CMsgAMGrantGuestPasses2Response.md)

#### Implements

IMessage<CMsgAMGrantGuestPasses2Response\>, 
[IEquatable<CMsgAMGrantGuestPasses2Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAMGrantGuestPasses2Response\>, 
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
[EnumerableExtensions.In<CMsgAMGrantGuestPasses2Response\>\(CMsgAMGrantGuestPasses2Response, params CMsgAMGrantGuestPasses2Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response__ctor"></a> CMsgAMGrantGuestPasses2Response\(\)

```csharp
public CMsgAMGrantGuestPasses2Response()
```

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response__ctor_Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_"></a> CMsgAMGrantGuestPasses2Response\(CMsgAMGrantGuestPasses2Response\)

```csharp
public CMsgAMGrantGuestPasses2Response(CMsgAMGrantGuestPasses2Response other)
```

#### Parameters

`other` [CMsgAMGrantGuestPasses2Response](Divine.Protobufs.Steam.CMsgAMGrantGuestPasses2Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_EresultFieldNumber"></a> EresultFieldNumber

```csharp
public const int EresultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_PassesGrantedFieldNumber"></a> PassesGrantedFieldNumber

```csharp
public const int PassesGrantedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_Eresult"></a> Eresult

```csharp
public int Eresult { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_HasEresult"></a> HasEresult

```csharp
public bool HasEresult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_HasPassesGranted"></a> HasPassesGranted

```csharp
public bool HasPassesGranted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAMGrantGuestPasses2Response> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAMGrantGuestPasses2Response](Divine.Protobufs.Steam.CMsgAMGrantGuestPasses2Response.md)\>

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_PassesGranted"></a> PassesGranted

```csharp
public int PassesGranted { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_ClearEresult"></a> ClearEresult\(\)

```csharp
public void ClearEresult()
```

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_ClearPassesGranted"></a> ClearPassesGranted\(\)

```csharp
public void ClearPassesGranted()
```

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_Clone"></a> Clone\(\)

```csharp
public CMsgAMGrantGuestPasses2Response Clone()
```

#### Returns

 [CMsgAMGrantGuestPasses2Response](Divine.Protobufs.Steam.CMsgAMGrantGuestPasses2Response.md)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_Equals_Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_"></a> Equals\(CMsgAMGrantGuestPasses2Response\)

```csharp
public bool Equals(CMsgAMGrantGuestPasses2Response other)
```

#### Parameters

`other` [CMsgAMGrantGuestPasses2Response](Divine.Protobufs.Steam.CMsgAMGrantGuestPasses2Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_MergeFrom_Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_"></a> MergeFrom\(CMsgAMGrantGuestPasses2Response\)

```csharp
public void MergeFrom(CMsgAMGrantGuestPasses2Response other)
```

#### Parameters

`other` [CMsgAMGrantGuestPasses2Response](Divine.Protobufs.Steam.CMsgAMGrantGuestPasses2Response.md)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgAMGrantGuestPasses2Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

