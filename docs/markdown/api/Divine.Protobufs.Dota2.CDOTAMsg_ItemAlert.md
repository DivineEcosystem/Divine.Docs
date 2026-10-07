# <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert"></a> Class CDOTAMsg\_ItemAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMsg_ItemAlert : IMessage<CDOTAMsg_ItemAlert>, IEquatable<CDOTAMsg_ItemAlert>, IDeepCloneable<CDOTAMsg_ItemAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMsg\_ItemAlert](Divine.Protobufs.Dota2.CDOTAMsg\_ItemAlert.md)

#### Implements

IMessage<CDOTAMsg\_ItemAlert\>, 
[IEquatable<CDOTAMsg\_ItemAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMsg\_ItemAlert\>, 
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
[EnumerableExtensions.In<CDOTAMsg\_ItemAlert\>\(CDOTAMsg\_ItemAlert, params CDOTAMsg\_ItemAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert__ctor"></a> CDOTAMsg\_ItemAlert\(\)

```csharp
public CDOTAMsg_ItemAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert__ctor_Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_"></a> CDOTAMsg\_ItemAlert\(CDOTAMsg\_ItemAlert\)

```csharp
public CDOTAMsg_ItemAlert(CDOTAMsg_ItemAlert other)
```

#### Parameters

`other` [CDOTAMsg\_ItemAlert](Divine.Protobufs.Dota2.CDOTAMsg\_ItemAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_ItemAbilityIdFieldNumber"></a> ItemAbilityIdFieldNumber

```csharp
public const int ItemAbilityIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_XFieldNumber"></a> XFieldNumber

```csharp
public const int XFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_YFieldNumber"></a> YFieldNumber

```csharp
public const int YFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_HasItemAbilityId"></a> HasItemAbilityId

```csharp
public bool HasItemAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_HasX"></a> HasX

```csharp
public bool HasX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_HasY"></a> HasY

```csharp
public bool HasY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_ItemAbilityId"></a> ItemAbilityId

```csharp
public int ItemAbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMsg_ItemAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMsg\_ItemAlert](Divine.Protobufs.Dota2.CDOTAMsg\_ItemAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_X"></a> X

```csharp
public int X { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_Y"></a> Y

```csharp
public int Y { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_ClearItemAbilityId"></a> ClearItemAbilityId\(\)

```csharp
public void ClearItemAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_ClearX"></a> ClearX\(\)

```csharp
public void ClearX()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_ClearY"></a> ClearY\(\)

```csharp
public void ClearY()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAMsg_ItemAlert Clone()
```

#### Returns

 [CDOTAMsg\_ItemAlert](Divine.Protobufs.Dota2.CDOTAMsg\_ItemAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_Equals_Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_"></a> Equals\(CDOTAMsg\_ItemAlert\)

```csharp
public bool Equals(CDOTAMsg_ItemAlert other)
```

#### Parameters

`other` [CDOTAMsg\_ItemAlert](Divine.Protobufs.Dota2.CDOTAMsg\_ItemAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_"></a> MergeFrom\(CDOTAMsg\_ItemAlert\)

```csharp
public void MergeFrom(CDOTAMsg_ItemAlert other)
```

#### Parameters

`other` [CDOTAMsg\_ItemAlert](Divine.Protobufs.Dota2.CDOTAMsg\_ItemAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_ItemAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

