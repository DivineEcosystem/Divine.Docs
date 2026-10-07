# <a id="Divine_Protobufs_Dota2_CMsgRGBA"></a> Class CMsgRGBA

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgRGBA : IMessage<CMsgRGBA>, IEquatable<CMsgRGBA>, IDeepCloneable<CMsgRGBA>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgRGBA](Divine.Protobufs.Dota2.CMsgRGBA.md)

#### Implements

IMessage<CMsgRGBA\>, 
[IEquatable<CMsgRGBA\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgRGBA\>, 
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
[EnumerableExtensions.In<CMsgRGBA\>\(CMsgRGBA, params CMsgRGBA\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgRGBA__ctor"></a> CMsgRGBA\(\)

```csharp
public CMsgRGBA()
```

### <a id="Divine_Protobufs_Dota2_CMsgRGBA__ctor_Divine_Protobufs_Dota2_CMsgRGBA_"></a> CMsgRGBA\(CMsgRGBA\)

```csharp
public CMsgRGBA(CMsgRGBA other)
```

#### Parameters

`other` [CMsgRGBA](Divine.Protobufs.Dota2.CMsgRGBA.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_AFieldNumber"></a> AFieldNumber

```csharp
public const int AFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_BFieldNumber"></a> BFieldNumber

```csharp
public const int BFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_GFieldNumber"></a> GFieldNumber

```csharp
public const int GFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_RFieldNumber"></a> RFieldNumber

```csharp
public const int RFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_A"></a> A

```csharp
public int A { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_B"></a> B

```csharp
public int B { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_G"></a> G

```csharp
public int G { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_HasA"></a> HasA

```csharp
public bool HasA { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_HasB"></a> HasB

```csharp
public bool HasB { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_HasG"></a> HasG

```csharp
public bool HasG { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_HasR"></a> HasR

```csharp
public bool HasR { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_Parser"></a> Parser

```csharp
public static MessageParser<CMsgRGBA> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgRGBA](Divine.Protobufs.Dota2.CMsgRGBA.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_R"></a> R

```csharp
public int R { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_ClearA"></a> ClearA\(\)

```csharp
public void ClearA()
```

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_ClearB"></a> ClearB\(\)

```csharp
public void ClearB()
```

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_ClearG"></a> ClearG\(\)

```csharp
public void ClearG()
```

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_ClearR"></a> ClearR\(\)

```csharp
public void ClearR()
```

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_Clone"></a> Clone\(\)

```csharp
public CMsgRGBA Clone()
```

#### Returns

 [CMsgRGBA](Divine.Protobufs.Dota2.CMsgRGBA.md)

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_Equals_Divine_Protobufs_Dota2_CMsgRGBA_"></a> Equals\(CMsgRGBA\)

```csharp
public bool Equals(CMsgRGBA other)
```

#### Parameters

`other` [CMsgRGBA](Divine.Protobufs.Dota2.CMsgRGBA.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_MergeFrom_Divine_Protobufs_Dota2_CMsgRGBA_"></a> MergeFrom\(CMsgRGBA\)

```csharp
public void MergeFrom(CMsgRGBA other)
```

#### Parameters

`other` [CMsgRGBA](Divine.Protobufs.Dota2.CMsgRGBA.md)

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgRGBA_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

