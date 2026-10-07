# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify"></a> Class CDOTAUserMsg\_CustomHudElement\_Modify

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_CustomHudElement_Modify : IMessage<CDOTAUserMsg_CustomHudElement_Modify>, IEquatable<CDOTAUserMsg_CustomHudElement_Modify>, IDeepCloneable<CDOTAUserMsg_CustomHudElement_Modify>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_CustomHudElement\_Modify](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHudElement\_Modify.md)

#### Implements

IMessage<CDOTAUserMsg\_CustomHudElement\_Modify\>, 
[IEquatable<CDOTAUserMsg\_CustomHudElement\_Modify\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_CustomHudElement\_Modify\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_CustomHudElement\_Modify\>\(CDOTAUserMsg\_CustomHudElement\_Modify, params CDOTAUserMsg\_CustomHudElement\_Modify\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify__ctor"></a> CDOTAUserMsg\_CustomHudElement\_Modify\(\)

```csharp
public CDOTAUserMsg_CustomHudElement_Modify()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_"></a> CDOTAUserMsg\_CustomHudElement\_Modify\(CDOTAUserMsg\_CustomHudElement\_Modify\)

```csharp
public CDOTAUserMsg_CustomHudElement_Modify(CDOTAUserMsg_CustomHudElement_Modify other)
```

#### Parameters

`other` [CDOTAUserMsg\_CustomHudElement\_Modify](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHudElement\_Modify.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_ElementIdFieldNumber"></a> ElementIdFieldNumber

```csharp
public const int ElementIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_ModifyVisibleFieldNumber"></a> ModifyVisibleFieldNumber

```csharp
public const int ModifyVisibleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_Data"></a> Data

```csharp
public ByteString Data { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_ElementId"></a> ElementId

```csharp
public string ElementId { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_HasElementId"></a> HasElementId

```csharp
public bool HasElementId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_HasModifyVisible"></a> HasModifyVisible

```csharp
public bool HasModifyVisible { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_ModifyVisible"></a> ModifyVisible

```csharp
public bool ModifyVisible { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_CustomHudElement_Modify> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_CustomHudElement\_Modify](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHudElement\_Modify.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_ClearElementId"></a> ClearElementId\(\)

```csharp
public void ClearElementId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_ClearModifyVisible"></a> ClearModifyVisible\(\)

```csharp
public void ClearModifyVisible()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_CustomHudElement_Modify Clone()
```

#### Returns

 [CDOTAUserMsg\_CustomHudElement\_Modify](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHudElement\_Modify.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_"></a> Equals\(CDOTAUserMsg\_CustomHudElement\_Modify\)

```csharp
public bool Equals(CDOTAUserMsg_CustomHudElement_Modify other)
```

#### Parameters

`other` [CDOTAUserMsg\_CustomHudElement\_Modify](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHudElement\_Modify.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_"></a> MergeFrom\(CDOTAUserMsg\_CustomHudElement\_Modify\)

```csharp
public void MergeFrom(CDOTAUserMsg_CustomHudElement_Modify other)
```

#### Parameters

`other` [CDOTAUserMsg\_CustomHudElement\_Modify](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHudElement\_Modify.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Modify_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

