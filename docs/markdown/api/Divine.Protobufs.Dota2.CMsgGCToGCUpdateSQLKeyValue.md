# <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue"></a> Class CMsgGCToGCUpdateSQLKeyValue

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCUpdateSQLKeyValue : IMessage<CMsgGCToGCUpdateSQLKeyValue>, IEquatable<CMsgGCToGCUpdateSQLKeyValue>, IDeepCloneable<CMsgGCToGCUpdateSQLKeyValue>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCUpdateSQLKeyValue](Divine.Protobufs.Dota2.CMsgGCToGCUpdateSQLKeyValue.md)

#### Implements

IMessage<CMsgGCToGCUpdateSQLKeyValue\>, 
[IEquatable<CMsgGCToGCUpdateSQLKeyValue\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCUpdateSQLKeyValue\>, 
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
[EnumerableExtensions.In<CMsgGCToGCUpdateSQLKeyValue\>\(CMsgGCToGCUpdateSQLKeyValue, params CMsgGCToGCUpdateSQLKeyValue\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue__ctor"></a> CMsgGCToGCUpdateSQLKeyValue\(\)

```csharp
public CMsgGCToGCUpdateSQLKeyValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue__ctor_Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue_"></a> CMsgGCToGCUpdateSQLKeyValue\(CMsgGCToGCUpdateSQLKeyValue\)

```csharp
public CMsgGCToGCUpdateSQLKeyValue(CMsgGCToGCUpdateSQLKeyValue other)
```

#### Parameters

`other` [CMsgGCToGCUpdateSQLKeyValue](Divine.Protobufs.Dota2.CMsgGCToGCUpdateSQLKeyValue.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue_KeyNameFieldNumber"></a> KeyNameFieldNumber

```csharp
public const int KeyNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue_HasKeyName"></a> HasKeyName

```csharp
public bool HasKeyName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue_KeyName"></a> KeyName

```csharp
public string KeyName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCUpdateSQLKeyValue> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCUpdateSQLKeyValue](Divine.Protobufs.Dota2.CMsgGCToGCUpdateSQLKeyValue.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue_ClearKeyName"></a> ClearKeyName\(\)

```csharp
public void ClearKeyName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCUpdateSQLKeyValue Clone()
```

#### Returns

 [CMsgGCToGCUpdateSQLKeyValue](Divine.Protobufs.Dota2.CMsgGCToGCUpdateSQLKeyValue.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue_Equals_Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue_"></a> Equals\(CMsgGCToGCUpdateSQLKeyValue\)

```csharp
public bool Equals(CMsgGCToGCUpdateSQLKeyValue other)
```

#### Parameters

`other` [CMsgGCToGCUpdateSQLKeyValue](Divine.Protobufs.Dota2.CMsgGCToGCUpdateSQLKeyValue.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue_"></a> MergeFrom\(CMsgGCToGCUpdateSQLKeyValue\)

```csharp
public void MergeFrom(CMsgGCToGCUpdateSQLKeyValue other)
```

#### Parameters

`other` [CMsgGCToGCUpdateSQLKeyValue](Divine.Protobufs.Dota2.CMsgGCToGCUpdateSQLKeyValue.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateSQLKeyValue_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

