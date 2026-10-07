# <a id="Divine_Protobufs_Steam_CMsgTOSTreatment"></a> Class CMsgTOSTreatment

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTOSTreatment : IMessage<CMsgTOSTreatment>, IEquatable<CMsgTOSTreatment>, IDeepCloneable<CMsgTOSTreatment>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTOSTreatment](Divine.Protobufs.Steam.CMsgTOSTreatment.md)

#### Implements

IMessage<CMsgTOSTreatment\>, 
[IEquatable<CMsgTOSTreatment\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTOSTreatment\>, 
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
[EnumerableExtensions.In<CMsgTOSTreatment\>\(CMsgTOSTreatment, params CMsgTOSTreatment\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment__ctor"></a> CMsgTOSTreatment\(\)

```csharp
public CMsgTOSTreatment()
```

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment__ctor_Divine_Protobufs_Steam_CMsgTOSTreatment_"></a> CMsgTOSTreatment\(CMsgTOSTreatment\)

```csharp
public CMsgTOSTreatment(CMsgTOSTreatment other)
```

#### Parameters

`other` [CMsgTOSTreatment](Divine.Protobufs.Steam.CMsgTOSTreatment.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_DownDscp45FieldNumber"></a> DownDscp45FieldNumber

```csharp
public const int DownDscp45FieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_L4SDetectFieldNumber"></a> L4SDetectFieldNumber

```csharp
public const int L4SDetectFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_UpEcn1FieldNumber"></a> UpEcn1FieldNumber

```csharp
public const int UpEcn1FieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_DownDscp45"></a> DownDscp45

```csharp
public string DownDscp45 { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_HasDownDscp45"></a> HasDownDscp45

```csharp
public bool HasDownDscp45 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_HasL4SDetect"></a> HasL4SDetect

```csharp
public bool HasL4SDetect { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_HasUpEcn1"></a> HasUpEcn1

```csharp
public bool HasUpEcn1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_L4SDetect"></a> L4SDetect

```csharp
public string L4SDetect { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTOSTreatment> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTOSTreatment](Divine.Protobufs.Steam.CMsgTOSTreatment.md)\>

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_UpEcn1"></a> UpEcn1

```csharp
public string UpEcn1 { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_ClearDownDscp45"></a> ClearDownDscp45\(\)

```csharp
public void ClearDownDscp45()
```

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_ClearL4SDetect"></a> ClearL4SDetect\(\)

```csharp
public void ClearL4SDetect()
```

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_ClearUpEcn1"></a> ClearUpEcn1\(\)

```csharp
public void ClearUpEcn1()
```

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_Clone"></a> Clone\(\)

```csharp
public CMsgTOSTreatment Clone()
```

#### Returns

 [CMsgTOSTreatment](Divine.Protobufs.Steam.CMsgTOSTreatment.md)

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_Equals_Divine_Protobufs_Steam_CMsgTOSTreatment_"></a> Equals\(CMsgTOSTreatment\)

```csharp
public bool Equals(CMsgTOSTreatment other)
```

#### Parameters

`other` [CMsgTOSTreatment](Divine.Protobufs.Steam.CMsgTOSTreatment.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_MergeFrom_Divine_Protobufs_Steam_CMsgTOSTreatment_"></a> MergeFrom\(CMsgTOSTreatment\)

```csharp
public void MergeFrom(CMsgTOSTreatment other)
```

#### Parameters

`other` [CMsgTOSTreatment](Divine.Protobufs.Steam.CMsgTOSTreatment.md)

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgTOSTreatment_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

