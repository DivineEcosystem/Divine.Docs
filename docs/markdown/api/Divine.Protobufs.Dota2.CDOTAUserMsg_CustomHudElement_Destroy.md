# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy"></a> Class CDOTAUserMsg\_CustomHudElement\_Destroy

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_CustomHudElement_Destroy : IMessage<CDOTAUserMsg_CustomHudElement_Destroy>, IEquatable<CDOTAUserMsg_CustomHudElement_Destroy>, IDeepCloneable<CDOTAUserMsg_CustomHudElement_Destroy>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_CustomHudElement\_Destroy](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHudElement\_Destroy.md)

#### Implements

IMessage<CDOTAUserMsg\_CustomHudElement\_Destroy\>, 
[IEquatable<CDOTAUserMsg\_CustomHudElement\_Destroy\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_CustomHudElement\_Destroy\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_CustomHudElement\_Destroy\>\(CDOTAUserMsg\_CustomHudElement\_Destroy, params CDOTAUserMsg\_CustomHudElement\_Destroy\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy__ctor"></a> CDOTAUserMsg\_CustomHudElement\_Destroy\(\)

```csharp
public CDOTAUserMsg_CustomHudElement_Destroy()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy_"></a> CDOTAUserMsg\_CustomHudElement\_Destroy\(CDOTAUserMsg\_CustomHudElement\_Destroy\)

```csharp
public CDOTAUserMsg_CustomHudElement_Destroy(CDOTAUserMsg_CustomHudElement_Destroy other)
```

#### Parameters

`other` [CDOTAUserMsg\_CustomHudElement\_Destroy](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHudElement\_Destroy.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy_ElementIdFieldNumber"></a> ElementIdFieldNumber

```csharp
public const int ElementIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy_ElementId"></a> ElementId

```csharp
public string ElementId { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy_HasElementId"></a> HasElementId

```csharp
public bool HasElementId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_CustomHudElement_Destroy> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_CustomHudElement\_Destroy](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHudElement\_Destroy.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy_ClearElementId"></a> ClearElementId\(\)

```csharp
public void ClearElementId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_CustomHudElement_Destroy Clone()
```

#### Returns

 [CDOTAUserMsg\_CustomHudElement\_Destroy](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHudElement\_Destroy.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy_"></a> Equals\(CDOTAUserMsg\_CustomHudElement\_Destroy\)

```csharp
public bool Equals(CDOTAUserMsg_CustomHudElement_Destroy other)
```

#### Parameters

`other` [CDOTAUserMsg\_CustomHudElement\_Destroy](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHudElement\_Destroy.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy_"></a> MergeFrom\(CDOTAUserMsg\_CustomHudElement\_Destroy\)

```csharp
public void MergeFrom(CDOTAUserMsg_CustomHudElement_Destroy other)
```

#### Parameters

`other` [CDOTAUserMsg\_CustomHudElement\_Destroy](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHudElement\_Destroy.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Destroy_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

