# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute"></a> Class CDOTAClientMsg\_AutoCourierExecute

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_AutoCourierExecute : IMessage<CDOTAClientMsg_AutoCourierExecute>, IEquatable<CDOTAClientMsg_AutoCourierExecute>, IDeepCloneable<CDOTAClientMsg_AutoCourierExecute>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_AutoCourierExecute](Divine.Protobufs.Dota2.CDOTAClientMsg\_AutoCourierExecute.md)

#### Implements

IMessage<CDOTAClientMsg\_AutoCourierExecute\>, 
[IEquatable<CDOTAClientMsg\_AutoCourierExecute\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_AutoCourierExecute\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_AutoCourierExecute\>\(CDOTAClientMsg\_AutoCourierExecute, params CDOTAClientMsg\_AutoCourierExecute\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute__ctor"></a> CDOTAClientMsg\_AutoCourierExecute\(\)

```csharp
public CDOTAClientMsg_AutoCourierExecute()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_"></a> CDOTAClientMsg\_AutoCourierExecute\(CDOTAClientMsg\_AutoCourierExecute\)

```csharp
public CDOTAClientMsg_AutoCourierExecute(CDOTAClientMsg_AutoCourierExecute other)
```

#### Parameters

`other` [CDOTAClientMsg\_AutoCourierExecute](Divine.Protobufs.Dota2.CDOTAClientMsg\_AutoCourierExecute.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_IsAutoDeliverFieldNumber"></a> IsAutoDeliverFieldNumber

```csharp
public const int IsAutoDeliverFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_TargetEntindexFieldNumber"></a> TargetEntindexFieldNumber

```csharp
public const int TargetEntindexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_HasIsAutoDeliver"></a> HasIsAutoDeliver

```csharp
public bool HasIsAutoDeliver { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_HasTargetEntindex"></a> HasTargetEntindex

```csharp
public bool HasTargetEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_IsAutoDeliver"></a> IsAutoDeliver

```csharp
public bool IsAutoDeliver { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_AutoCourierExecute> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_AutoCourierExecute](Divine.Protobufs.Dota2.CDOTAClientMsg\_AutoCourierExecute.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_TargetEntindex"></a> TargetEntindex

```csharp
public int TargetEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_ClearIsAutoDeliver"></a> ClearIsAutoDeliver\(\)

```csharp
public void ClearIsAutoDeliver()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_ClearTargetEntindex"></a> ClearTargetEntindex\(\)

```csharp
public void ClearTargetEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_AutoCourierExecute Clone()
```

#### Returns

 [CDOTAClientMsg\_AutoCourierExecute](Divine.Protobufs.Dota2.CDOTAClientMsg\_AutoCourierExecute.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_"></a> Equals\(CDOTAClientMsg\_AutoCourierExecute\)

```csharp
public bool Equals(CDOTAClientMsg_AutoCourierExecute other)
```

#### Parameters

`other` [CDOTAClientMsg\_AutoCourierExecute](Divine.Protobufs.Dota2.CDOTAClientMsg\_AutoCourierExecute.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_"></a> MergeFrom\(CDOTAClientMsg\_AutoCourierExecute\)

```csharp
public void MergeFrom(CDOTAClientMsg_AutoCourierExecute other)
```

#### Parameters

`other` [CDOTAClientMsg\_AutoCourierExecute](Divine.Protobufs.Dota2.CDOTAClientMsg\_AutoCourierExecute.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AutoCourierExecute_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

