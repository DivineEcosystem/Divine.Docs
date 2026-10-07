# <a id="Divine_Protobufs_Dota2_CClientMsg_RotateAnchor"></a> Class CClientMsg\_RotateAnchor

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CClientMsg_RotateAnchor : IMessage<CClientMsg_RotateAnchor>, IEquatable<CClientMsg_RotateAnchor>, IDeepCloneable<CClientMsg_RotateAnchor>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CClientMsg\_RotateAnchor](Divine.Protobufs.Dota2.CClientMsg\_RotateAnchor.md)

#### Implements

IMessage<CClientMsg\_RotateAnchor\>, 
[IEquatable<CClientMsg\_RotateAnchor\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CClientMsg\_RotateAnchor\>, 
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
[EnumerableExtensions.In<CClientMsg\_RotateAnchor\>\(CClientMsg\_RotateAnchor, params CClientMsg\_RotateAnchor\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CClientMsg_RotateAnchor__ctor"></a> CClientMsg\_RotateAnchor\(\)

```csharp
public CClientMsg_RotateAnchor()
```

### <a id="Divine_Protobufs_Dota2_CClientMsg_RotateAnchor__ctor_Divine_Protobufs_Dota2_CClientMsg_RotateAnchor_"></a> CClientMsg\_RotateAnchor\(CClientMsg\_RotateAnchor\)

```csharp
public CClientMsg_RotateAnchor(CClientMsg_RotateAnchor other)
```

#### Parameters

`other` [CClientMsg\_RotateAnchor](Divine.Protobufs.Dota2.CClientMsg\_RotateAnchor.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CClientMsg_RotateAnchor_AngleFieldNumber"></a> AngleFieldNumber

```csharp
public const int AngleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CClientMsg_RotateAnchor_Angle"></a> Angle

```csharp
public float Angle { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CClientMsg_RotateAnchor_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CClientMsg_RotateAnchor_HasAngle"></a> HasAngle

```csharp
public bool HasAngle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_RotateAnchor_Parser"></a> Parser

```csharp
public static MessageParser<CClientMsg_RotateAnchor> Parser { get; }
```

#### Property Value

 MessageParser<[CClientMsg\_RotateAnchor](Divine.Protobufs.Dota2.CClientMsg\_RotateAnchor.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CClientMsg_RotateAnchor_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_RotateAnchor_ClearAngle"></a> ClearAngle\(\)

```csharp
public void ClearAngle()
```

### <a id="Divine_Protobufs_Dota2_CClientMsg_RotateAnchor_Clone"></a> Clone\(\)

```csharp
public CClientMsg_RotateAnchor Clone()
```

#### Returns

 [CClientMsg\_RotateAnchor](Divine.Protobufs.Dota2.CClientMsg\_RotateAnchor.md)

### <a id="Divine_Protobufs_Dota2_CClientMsg_RotateAnchor_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_RotateAnchor_Equals_Divine_Protobufs_Dota2_CClientMsg_RotateAnchor_"></a> Equals\(CClientMsg\_RotateAnchor\)

```csharp
public bool Equals(CClientMsg_RotateAnchor other)
```

#### Parameters

`other` [CClientMsg\_RotateAnchor](Divine.Protobufs.Dota2.CClientMsg\_RotateAnchor.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_RotateAnchor_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_RotateAnchor_MergeFrom_Divine_Protobufs_Dota2_CClientMsg_RotateAnchor_"></a> MergeFrom\(CClientMsg\_RotateAnchor\)

```csharp
public void MergeFrom(CClientMsg_RotateAnchor other)
```

#### Parameters

`other` [CClientMsg\_RotateAnchor](Divine.Protobufs.Dota2.CClientMsg\_RotateAnchor.md)

### <a id="Divine_Protobufs_Dota2_CClientMsg_RotateAnchor_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CClientMsg_RotateAnchor_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CClientMsg_RotateAnchor_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

